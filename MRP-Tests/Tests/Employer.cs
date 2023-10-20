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
using Assert = NUnit.Framework.Assert;

namespace MRPTests.Tests
{
    class Employer : MrpTestBase
    {
        Login login = new Login();

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TestEmployer(String Correct)
        {

            login.Login_Page(Correct);
            TestId = login.TestId;
            System.Threading.Thread.Sleep(DelayScreenChange);

            SetStepName("ClickOnCommunity");
            try
            {
                WaitUntilElementClickable(By.CssSelector(Careers_locators.community)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("ClickonCareerCenter");
            try
            {
                WaitUntilElementClickable(By.CssSelector(Careers_locators.Career_center)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }


            SetStepName("ClickOnEmployerTab");

            GetElementWithText(null, By.CssSelector("div.mat-tab-label-content"), "Employers").Click();
            System.Threading.Thread.Sleep(DelayScreenChange);
            Assert.IsTrue(true);
            SetStepName("ClickOnPostJob");
            try
            {
                WaitUntilElementExists(By.CssSelector(Careers_locators.post_job)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("EnterCompanyName");
            try
            {

                WaitUntilElementClickable(By.CssSelector("input[formcontrolname='companyName']")).SendKeys(s_k_values.company_name);
                System.Threading.Thread.Sleep(DelayPrompt);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("EnterJobTitle");
            try
            {

                WaitUntilElementExists(By.CssSelector(Careers_locators.job_title)).SendKeys(s_k_values.job__title);
                System.Threading.Thread.Sleep(DelayPrompt);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("EnterEmail");
            try
            {

                WaitUntilElementExists(By.CssSelector(Careers_locators.email)).SendKeys(s_k_values.resume_send_email);
                System.Threading.Thread.Sleep(DelayPrompt);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("SwitchToCareersiFrame");
            try
            {
                IWebElement iframe = WaitUntilElementExists(By.CssSelector(Careers_locators.iframe));
                driver.SwitchTo().Frame(iframe);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }



            try
            {
                SetStepName("EnterText");
                var enterText = WaitUntilElementExists(By.CssSelector(Careers_locators.enter_text));
                if (enterText != null)
                {
                    ScrollIntoView(enterText);
                    enterText.SendKeys(s_k_values.rich_text);
                }
                System.Threading.Thread.Sleep(DelayPrompt);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }


            try
            {
                driver.SwitchTo().DefaultContent();

                ScrollView(-350);
                SetStepName("ClickOnPreview");
                if (IsElementDisplayed(By.XPath(Careers_locators.preview)))
                {
                    WaitUntilElementClickable(By.XPath(Careers_locators.preview)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                else
                {
                    Console.WriteLine("Element not found");
                    System.Diagnostics.Debug.WriteLine("Element not found");
                }
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }


            try
            {
                SetStepName("ClickOnConfirm");
                if (IsElementDisplayed(By.XPath(Careers_locators.confirm)))
                {
                    WaitUntilElementClickable(By.XPath(Careers_locators.confirm)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }

                else
                {

                    Console.WriteLine("Element not found");
                    System.Diagnostics.Debug.WriteLine("Element not found");
                }
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            try
            {
                SetStepName("ConfirmPopup");
                if (IsElementDisplayed(By.CssSelector(Careers_locators.confirm_popup)))
                {

                    WaitUntilElementClickable(By.CssSelector(Careers_locators.confirm_popup)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }

                else
                {

                    Console.WriteLine("Element not found");
                    System.Diagnostics.Debug.WriteLine("Element not found");
                }
                Assert.IsTrue(true);

            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            try
            {
                SetStepName("SelectProduct");
                var navStepSpan = WaitUntilElementVisible(By.CssSelector("div.nav-step span.hidden-sm-down"));
                if ((navStepSpan == null) || (!navStepSpan.Text.Contains("Career Center Products")))
                    Assert.IsTrue(false);

                var products = GetElements(null, By.CssSelector("div.product-selection"));
                if (products != null)
                {
                    foreach(var productDiv in products)
                    {
                        var p = GetElementWithText(productDiv, By.CssSelector("p"), "Zero Career Center Product");
                        if (p != null)
                        {
                            var addBtn = GetElement(productDiv, By.CssSelector("button[data-test*='product-select-button']"));
                            if (addBtn != null)
                            {
                                ScrollIntoView(addBtn);
                                addBtn.Click();
                                break;
                            }
                        }
                    }
                }
                System.Threading.Thread.Sleep(DelayScreenChange);
            }
            catch(Exception ex)
            {
            }

            try
            {
                WaitUntilElementClickable(By.CssSelector("div.action-buttons button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                Assert.IsTrue(true);
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }


            try
            {
                WaitUntilElementClickable(By.CssSelector("div.action-buttons button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange * 3);

                var myJobPostings = WaitUntilElementVisible(By.CssSelector("div.my-job-posting-detail-section"));
                if (myJobPostings != null)
                    Assert.IsTrue(true);
                else
                    Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false, ex.Message);
            }
        }

        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void OrgTestEmployer(String Correct)
        {

            login.Login_OrgPage(Correct);
            TestId = login.TestId;
            System.Threading.Thread.Sleep(DelayScreenChange);

            SetStepName("ClickOnCommunity");
            try
            {
                WaitUntilElementClickable(By.CssSelector(Careers_locators.community)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("ClickonCareerCenter");
            try
            {
                WaitUntilElementClickable(By.CssSelector(Careers_locators.Career_center)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }


            SetStepName("ClickOnEmployerTab");
            try
            {
                if (IsElementDisplayed(By.XPath(Careers_locators.Employer_Tab)))
                {

                    WaitUntilElementClickable(By.XPath(Careers_locators.Employer_Tab)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }

                else
                {

                    Console.WriteLine("Element not found");
                    System.Diagnostics.Debug.WriteLine("Element not found");
                }
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("ClickOnPostJob");
            try
            {
                WaitUntilElementExists(By.CssSelector(Careers_locators.post_job)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("EnterCompanyName");
            try
            {

                WaitUntilElementClickable(By.CssSelector("input[formcontrolname='companyName']")).SendKeys(s_k_values.company_name);
                System.Threading.Thread.Sleep(DelayPrompt);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("EnterJobTitle");
            try
            {

                WaitUntilElementExists(By.CssSelector(Careers_locators.job_title)).SendKeys(s_k_values.job__title);
                System.Threading.Thread.Sleep(DelayPrompt);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("EnterEmail");
            try
            {

                WaitUntilElementExists(By.CssSelector(Careers_locators.email)).SendKeys(s_k_values.resume_send_email);
                System.Threading.Thread.Sleep(DelayPrompt);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            SetStepName("SwitchToCareersiFrame");
            try
            {
                IWebElement iframe = WaitUntilElementExists(By.CssSelector(Careers_locators.iframe));
                driver.SwitchTo().Frame(iframe);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }



            try
            {
                SetStepName("EnterText");
                var enterText = WaitUntilElementExists(By.CssSelector(Careers_locators.enter_text));
                if (enterText != null)
                {
                    ScrollIntoView(enterText);
                    enterText.SendKeys(s_k_values.rich_text);
                }
                System.Threading.Thread.Sleep(DelayPrompt);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }


            try
            {
                driver.SwitchTo().DefaultContent();

                ScrollView(-350);
                SetStepName("ClickOnPreview");
                if (IsElementDisplayed(By.XPath(Careers_locators.preview)))
                {
                    WaitUntilElementClickable(By.XPath(Careers_locators.preview)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                else
                {
                    Console.WriteLine("Element not found");
                    System.Diagnostics.Debug.WriteLine("Element not found");
                }
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }


            try
            {
                SetStepName("ClickOnConfirm");
                if (IsElementDisplayed(By.XPath(Careers_locators.confirm)))
                {
                    WaitUntilElementClickable(By.XPath(Careers_locators.confirm)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }

                else
                {

                    Console.WriteLine("Element not found");
                    System.Diagnostics.Debug.WriteLine("Element not found");
                }
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            try
            {
                SetStepName("ConfirmPopup");
                if (IsElementDisplayed(By.CssSelector(Careers_locators.confirm_popup)))
                {

                    WaitUntilElementClickable(By.CssSelector(Careers_locators.confirm_popup)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }

                else
                {

                    Console.WriteLine("Element not found");
                    System.Diagnostics.Debug.WriteLine("Element not found");
                }
                Assert.IsTrue(true);

            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }

            try
            {
                SetStepName("SelectProduct");
                var navStepSpan = WaitUntilElementVisible(By.CssSelector("div.nav-step span.hidden-sm-down"));
                if ((navStepSpan == null) || (!navStepSpan.Text.Contains("Career Center Products")))
                    Assert.IsTrue(false);

                var products = GetElements(null, By.CssSelector("div.product-selection"));
                if (products != null)
                {
                    foreach (var productDiv in products)
                    {
                        var p = GetElementWithText(productDiv, By.CssSelector("p"), "Zero Career Center Product");
                        if (p != null)
                        {
                            var addBtn = GetElement(productDiv, By.CssSelector("button[data-test*='product-select-button']"));
                            if (addBtn != null)
                            {
                                ScrollIntoView(addBtn);
                                addBtn.Click();
                                break;
                            }
                        }
                    }
                }
                System.Threading.Thread.Sleep(DelayScreenChange);
                //Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
            }

            try
            {
                WaitUntilElementClickable(By.CssSelector("div.action-buttons button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }


            try
            {
                WaitUntilElementClickable(By.CssSelector("div.action-buttons button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                //SetStepName("StartingCheckout");
                //PayLaterCheckout();
                var myJobPostings = WaitUntilElementVisible(By.CssSelector("div.my-job-posting-detail-section"));
                if (myJobPostings != null)
                    Assert.IsTrue(true);
                else
                    Assert.IsTrue(false);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false, ex.Message);
            }
        }
    }
}
