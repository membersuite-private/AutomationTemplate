using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRPTests.Config;
using MRPTests.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using Assert = NUnit.Framework.Assert;

namespace MRPTests.Tests
{
    public class Join : MrpTestBase
    {
        public string EmailAddress { get; set; } = "";

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void JoinViaMRP(String Correct)
        {
            CheckEmailTempMail tempMail = null;

            try
            {
                tempMail = new CheckEmailTempMail();
                EmailAddress = tempMail.EmailAddress;

                Thread.Sleep(DelayScreenChange);
                BrowserSetup(Correct);

                driver.Navigate().GoToUrl(config.RunEnvironment.ToLower() == "prod" ? config.ProdUrl : config.RunEnvironment.ToLower() == "green" ? config.GreenUrl : config.BlueUrl);
                driver.Manage().Cookies.DeleteAllCookies();

                //allow cookies
                WaitUntilElementExists(By.XPath("/html/body/div[1]/div/a")).Click();
                Thread.Sleep(DelayScreenChange);

                //Click on Profile icon
                SetStepName("ClickOnProfile");
                IWebElement profile = GetElement(null, By.CssSelector("profile-chip[style]"), By.CssSelector("div.profile img.profile-image"));
                if (profile.Displayed)
                {
                    profile.Click();
                    System.Diagnostics.Debug.WriteLine("Creds Entered");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Creds Entered");
                }

                Thread.Sleep(DelayScreenChange);
                SetStepName("ClickOnJoin");
                GetElement(null,By.CssSelector("profile-chip[style]"),By.CssSelector("a[data-test='menu-join']")).Click();
                Thread.Sleep(DelayScreenChange);

                string timestampStr = DateTime.Now.ToString("yyyyMMddHHmmss");
                string emailAddr = "mrp" + timestampStr;

                SetStepName("EnterUsernameEmailPwd");

                if (IsGreen)
                    WaitUntilElementVisible(By.CssSelector("input[placeholder='Username'")).SendKeys(emailAddr);
                else
                    WaitUntilElementVisible(By.CssSelector("input[type='username'")).SendKeys(emailAddr);
                Thread.Sleep(DelayPrompt);

                WaitUntilElementVisible(By.CssSelector("input[type='email'")).SendKeys(EmailAddress);
                Thread.Sleep(DelayPrompt);
                WaitUntilElementVisible(By.CssSelector("input[type='password'")).SendKeys("Te$t1234");
                Thread.Sleep(DelayPrompt);
                SetStepName("ClickOnSignup");
                if (IsGreen)
                    WaitUntilElementVisible(By.CssSelector("button.signUpButton")).Click();
                else
                    WaitUntilElementVisible(By.CssSelector("button.sign-up-button")).Click();
                Thread.Sleep(DelayScreenChange);

                string verificationCode = "";
                int attempts = 0;
                while(string.IsNullOrEmpty(verificationCode) == true)
                {
                    verificationCode = tempMail.GetVerificationCode;
                    if (string.IsNullOrEmpty(verificationCode) == true)
                    {
                        attempts++;
                        if (attempts > 400)
                            Assert.IsTrue(false, "Failed to get verification code in email");
                        Thread.Sleep(10000);
                    }
                }
                tempMail.CleanUp();

                if (ElementExist(By.CssSelector("input.verification-code")))
                    WaitUntilElementVisible(By.CssSelector("input.verification-code")).SendKeys(verificationCode);
                else
                    WaitUntilElementVisible(By.CssSelector("input[type='password']")).SendKeys(verificationCode);
                Thread.Sleep(DelayPrompt);
                SetStepName("ConfirmVerificationCode");
                if (IsGreen)
                    WaitUntilElementVisible(By.CssSelector("button[name='confirm']")).Click();
                else
                    WaitUntilElementVisible(By.CssSelector("button.verification-code")).Click();
                Thread.Sleep(DelayScreenChange);

                EnterKeys("First" + timestampStr, "input[name='firstName']", "EnterFirstName");
                Thread.Sleep(DelayPrompt);

                EnterKeys("Smith", "input[name='lastName']", "EnterLastName");
                Thread.Sleep(DelayPrompt);

                SetStepName("SelectIndividualType");
                try
                {
                    var inputType = WaitUntilElementVisible(By.CssSelector("mat-select[name='individualType']"));
                    if (inputType != null)
                    {
                        ScrollIntoView(inputType);
                        Thread.Sleep(500);
                        inputType.Click();
                    }
                }
                catch { }
                Thread.Sleep(DelayPrompt);
                var individualTypes = GetElements(null, By.CssSelector("mat-option"));
                if (individualTypes != null)
                    individualTypes.First().Click();
                Thread.Sleep(DelayPrompt);

                SetStepName("EnterAge");
                if (IsProduction)
                {
                    WaitUntilElementVisible(By.CssSelector("input[data-test='question-3']")).SendKeys("65");
                    Thread.Sleep(DelayWaitOnSelection);
                }
                else if (IsGreen)
                {
                    WaitUntilElementVisible(By.CssSelector("input[data-test='question-4']")).SendKeys("65");
                    Thread.Sleep(DelayWaitOnSelection);
                }
                {
                    try
                    {
                        SetStepName("EnterAddress");
                        var addrGroups = GetElements(null, By.CssSelector("mat-radio-group[name='addressType']"));
                        if ((addrGroups != null) && (addrGroups.Count > 0))
                        {
                            var addrGroup = addrGroups.First();
                            if (addrGroup != null)
                            {
                                ScrollIntoView(addrGroup);
                                var addrButtons = GetElements(addrGroup, By.CssSelector("mat-radio-button"));
                                if ((addrButtons != null) && (addrButtons.Count > 0))
                                {
                                    addrButtons.First().Click();
                                    Thread.Sleep(DelayPrompt);
                                }

                                EnterKeys("100 N MAIN ST", "input[data-test='input-address-line-1']");
                                Thread.Sleep(DelayPrompt);

                                EnterKeys("OWASSO", "input[data-test='input-city']");
                                Thread.Sleep(DelayPrompt);

                                EnterKeys("74055", "input[data-test='input-zip']");
                                Thread.Sleep(DelayPrompt);
                                WaitUntilElementVisible(By.CssSelector("mat-select[data-test='input-state']")).Click();
                                Thread.Sleep(DelayPrompt);
                                if (IsProduction)
                                    GetElementWithText(null, By.CssSelector("mat-option"), "Oklahoma").Click();
                                else
                                    WaitUntilElementVisible(By.CssSelector("mat-option[ng-reflect-value='OK']")).Click();
                                Thread.Sleep(DelayPrompt);
                                WaitUntilElementVisible(By.CssSelector("mat-select[data-test='input-country']")).Click();
                                Thread.Sleep(DelayPrompt);
                                if (IsProduction)
                                    GetElementWithText(null, By.CssSelector("mat-option"), "United States").Click();
                                else
                                    WaitUntilElementVisible(By.CssSelector("mat-option[ng-reflect-value='US']")).Click();

                                var valButtons = GetElements(null, By.CssSelector("button.add-btn"));
                                if (valButtons != null)
                                {
                                    foreach(var valBtn in valButtons)
                                    {
                                        if (valBtn.Text.Contains("Validate and Save Address"))
                                            valBtn.Click();
                                    }
                                }
                                Thread.Sleep(DelayWaitOnSelection);

                                try
                                {
                                    var modalMsg = GetElement(null, By.CssSelector("modal-message"));
                                    if (modalMsg != null)
                                    {
                                        var SaveAnywayBtn = GetElement(modalMsg, By.CssSelector("button.button-blue"));
                                        SaveAnywayBtn.Click();
                                    }
                                }
                                catch { }
                            }
                        }

                        EnterKeys("25", "How many years", "mat-placeholder", "input[type='number']");
                        Thread.Sleep(DelayPrompt);
                    }
                    catch { }
                }

                SetStepName("ClickContinue");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                Thread.Sleep(DelayScreenChange);


                SetStepName("SelectNoOrg");
                var buttonGroup = WaitUntilElementVisible(By.CssSelector("mat-radio-group"));
                Thread.Sleep(DelayWaitOnSelection);
                var buttons = GetElements(buttonGroup, By.CssSelector("mat-radio-button"));
                if ((buttons != null) && (buttons.Count >= 3))
                {
                    buttons.Skip(2).First().Click();
                }
                else
                    Assert.IsTrue(false);

                SetStepName("Continue");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                Thread.Sleep(DelayScreenChange);

                SetStepName("DefaultCommunications");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                Thread.Sleep(DelayScreenChange);

                var acctCreatedLabel = WaitUntilElementVisible(By.CssSelector("span.account-created-info"));

                SetStepName("ClickHome");                
                if (ElementExist(By.CssSelector("button.home-button")))
                {
                    WaitUntilElementVisible(By.CssSelector("button.home-button")).Click();
                    Thread.Sleep(DelayScreenChange);
                }
                SetStepName("JoinSuccessful");
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                TestError(e);
                Console.WriteLine("test case failed" + e.Message);
                NUnit.Framework.Assert.IsTrue(false, "Exception:" + e.Message);
            }
            finally
            {
                tempMail.CleanUp();
            }
        }
    }
}
