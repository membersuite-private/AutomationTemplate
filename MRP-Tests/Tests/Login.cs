using MRPTests.Config;
using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Security.Policy;
using MRPTests.Helper;
using System.Linq;

namespace MRPTests.Tests
{
    [TestClass]
    public class Login : TestBase
    {
        public Login() { }
        public Login(TestBase testBase)
        {
            BrowserName = testBase.BrowserName;
            TestName = testBase.TestName;
            TestId = testBase.TestId;
        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void Login_Page(String Correct)
        {
            try
            {
                BrowserSetup(Correct);

                driver.Navigate().GoToUrl(MrpUrl);
                driver.Manage().Cookies.DeleteAllCookies();
                System.Diagnostics.Debug.WriteLine("Creds Entered");

                //allow cookies
                WaitUntilElementExists(By.XPath("/html/body/div[1]/div/a")).Click();
                //Click on Profile icon
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectingProfile");
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
                System.Diagnostics.Debug.WriteLine("Control Switch");
                IWebElement Loginbtn = WaitUntilElementExists(By.XPath("//menu[@class='dropdown expanded']//a[contains(.,'Login')]"));
                if (Loginbtn.Displayed)
                {
                    System.Diagnostics.Debug.WriteLine("Button found");
                    Loginbtn.Click();

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Button not found");
                }


                Console.WriteLine("DOne");
                Thread.Sleep(DelayScreenChange);


                SetStepName("EnterLoginCreds");
                if ((!IsGreen) && (!ElementExist(By.CssSelector("div.natia-signup"))))
                {
                    WaitUntilElementVisible(By.CssSelector("input[type='text']")).SendKeys(MrpUsername);
                    Thread.Sleep(DelayPrompt);
                    WaitUntilElementVisible(By.CssSelector("input[type='password']")).SendKeys(MrpPassword);
                    Thread.Sleep(DelayPrompt);
                    SetStepName("ClickingLoginButton");
                    WaitUntilElementVisible(By.CssSelector("button.sign-up-button")).Click();
                    Thread.Sleep(DelayScreenChange);
                }
                else
                {
                    IWebElement element2 = WaitUntilElementExists(By.XPath("//div[@class='modal-content background-customizable modal-content-mobile visible-md visible-lg']//label[.='Username']"));
                    if (element2.Displayed)

                    {
                        System.Diagnostics.Debug.WriteLine("Element found", element2.Text);
                    }
                    else
                    {

                        Console.WriteLine("Element not found");
                        System.Diagnostics.Debug.WriteLine("Element not found");
                    }

                    driver.SwitchTo().ActiveElement();
                    WaitUntilElementExists(By.XPath
                        ("//div[@class='modal-content background-customizable modal-content-mobile visible-md visible-lg']//input[@id='signInFormUsername']"))
                        .SendKeys(MrpUsername);
                    System.Diagnostics.Debug.WriteLine("Creds Entered");
                    WaitUntilElementExists(By.XPath("//div[@class='modal-content background-customizable modal-content-mobile visible-md visible-lg']//input[@id='signInFormPassword']"))
                        .SendKeys(MrpPassword);
                    System.Diagnostics.Debug.WriteLine("Creds Entered");
                    SetStepName("ClickingLoginButton");
                    //Click Login Button
                    WaitUntilElementExists
                        (By.XPath("//div[@class='modal-content background-customizable modal-content-mobile visible-md visible-lg']//input[@name='signInSubmitButton']")).Click();
                    System.Diagnostics.Debug.WriteLine("Click Login Button");
                    Thread.Sleep(DelayScreenChange);
                }

                Thread.Sleep(DelayScreenChange * 2);
                SetStepName("SelectActiveProfile");
                GetElement(null, By.CssSelector("div.cdk-overlay-container"), By.CssSelector("div.selectedRelationship"), By.CssSelector("img[class='switch-profile-user-image activeProfile']")).Click();
                Thread.Sleep(DelayScreenChange);
                var Equal_value = (driver.Title == MrpLoginPageTitle);
                NUnit.Framework.Assert.IsTrue(Equal_value);
                Console.WriteLine("test case Passed");
                SetStepName("LoggedIn");
            }
            catch (Exception e)
            {
                TestError(e);
                Console.WriteLine("test case failed" + e.Message);
                NUnit.Framework.Assert.IsTrue(false, "Exception:" + e.Message);
            }


        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void Login_OrgPage(String Correct)
        {
            try
            {
                BrowserSetup(Correct);

                driver.Navigate().GoToUrl(MrpUrl);
                driver.Manage().Cookies.DeleteAllCookies();
                System.Diagnostics.Debug.WriteLine("Creds Entered");

                //allow cookies
                WaitUntilElementExists(By.XPath("/html/body/div[1]/div/a")).Click();
                //Click on Profile icon
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectingProfile");
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
                System.Diagnostics.Debug.WriteLine("Control Switch");
                IWebElement Loginbtn = WaitUntilElementExists(By.XPath("//menu[@class='dropdown expanded']//a[contains(.,'Login')]"));
                if (Loginbtn.Displayed)
                {
                    System.Diagnostics.Debug.WriteLine("Button found");
                    Loginbtn.Click();

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Button not found");
                }


                Console.WriteLine("DOne");
                Thread.Sleep(DelayScreenChange);


                SetStepName("EnterLoginCreds");
                if ((!IsGreen) && (!ElementExist(By.CssSelector("div.natia-signup"))))
                {
                    WaitUntilElementVisible(By.CssSelector("input[type='text']")).SendKeys(MrpUsername);
                    Thread.Sleep(DelayPrompt);
                    WaitUntilElementVisible(By.CssSelector("input[type='password']")).SendKeys(MrpPassword);
                    Thread.Sleep(DelayPrompt);
                    SetStepName("ClickingLoginButton");
                    WaitUntilElementVisible(By.CssSelector("button.sign-up-button")).Click();
                    Thread.Sleep(DelayScreenChange);
                }
                else
                {
                    IWebElement element2 = WaitUntilElementExists(By.XPath("//div[@class='modal-content background-customizable modal-content-mobile visible-md visible-lg']//label[.='Username']"));
                    if (element2.Displayed)

                    {
                        System.Diagnostics.Debug.WriteLine("Element found", element2.Text);
                    }
                    else
                    {

                        Console.WriteLine("Element not found");
                        System.Diagnostics.Debug.WriteLine("Element not found");
                    }

                    driver.SwitchTo().ActiveElement();
                    WaitUntilElementExists(By.XPath
                        ("//div[@class='modal-content background-customizable modal-content-mobile visible-md visible-lg']//input[@id='signInFormUsername']"))
                        .SendKeys(MrpUsername);
                    System.Diagnostics.Debug.WriteLine("Creds Entered");
                    WaitUntilElementExists(By.XPath("//div[@class='modal-content background-customizable modal-content-mobile visible-md visible-lg']//input[@id='signInFormPassword']"))
                        .SendKeys(MrpPassword);
                    System.Diagnostics.Debug.WriteLine("Creds Entered");
                    SetStepName("ClickingLoginButton");
                    //Click Login Button
                    WaitUntilElementExists
                        (By.XPath("//div[@class='modal-content background-customizable modal-content-mobile visible-md visible-lg']//input[@name='signInSubmitButton']")).Click();
                    System.Diagnostics.Debug.WriteLine("Click Login Button");
                    Thread.Sleep(DelayScreenChange);
                }

                Thread.Sleep(DelayScreenChange);
                SetStepName("SelectActiveProfile");
                if (IsProduction)
                    GetElement(null, By.CssSelector("div.cdk-overlay-container"), By.CssSelector("div.selectedRelationship"), By.CssSelector("img[src='https://images.membersuite.com/eb12a7be-0004-c2c7-1b59-0b3fb87d8577/31961/eb12a7be-001c-c148-d848-4fc44b0f2c22']")).Click();
                else if (IsGreen)
                    GetElement(null, By.CssSelector("div.cdk-overlay-container"), By.CssSelector("div.selectedRelationship"), By.CssSelector("img[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-cd0c-d848-d0fa2660b698']")).Click();
                else
                    GetElement(null, By.CssSelector("div.cdk-overlay-container"), By.CssSelector("div.selectedRelationship"), By.CssSelector("img[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-cd67-d848-8270d8608398']")).Click();

                Thread.Sleep(DelayScreenChange);
                var Equal_value = (driver.Title == MrpLoginPageTitle);
                NUnit.Framework.Assert.IsTrue(Equal_value);
                Console.WriteLine("test case Passed");
                SetStepName("LoggedIn");
            }
            catch (Exception e)
            {
                TestError(e);
                Console.WriteLine("test case failed" + e.Message);
                NUnit.Framework.Assert.IsTrue(false, "Exception:" + e.Message);
            }


        }

    }

    
}
