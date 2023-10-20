using MRPTests.Config;
using MRPTests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace MRPTests.Tests
{
    class Membership : MrpTestBase

    {
        Login login = new Login();

        private bool SelectFirstChapter(string primaryChapter)
        {
            Boolean chapterChecked = false;
            ScrollView(300);
            System.Threading.Thread.Sleep(DelayScreenChange);
            ScrollToTop();
            System.Threading.Thread.Sleep(DelayWaitOnSelection);
            try
            {
                var chapters = GetElements(null, By.CssSelector("mat-checkbox"));
                if (chapters != null)
                {
                    foreach (var chapter in chapters)
                    {
                        if (!chapterChecked)
                        {
                            var labels = GetElements(chapter, By.CssSelector("span.mat-checkbox-label"));
                            if (labels != null)
                            {
                                foreach (var lab in labels)
                                {
                                    string labStr = lab.Text.Trim();
                                    if (labStr.Contains("$"))
                                    {
                                        labStr = labStr.Substring(0, labStr.IndexOf('$')).TrimEnd();
                                    }
                                    if ((labStr != primaryChapter) && (string.IsNullOrEmpty(labStr) == false))
                                    {
                                        ScrollIntoView(chapter);
                                        SetStepName("ClickOnChapter");
                                        try
                                        {
                                            chapter.Click();
                                        }
                                        catch
                                        {
                                            lab.Click();
                                        }
                                        chapterChecked = true;
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch { return false; }
            return false;
        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void Membership_Dues(String Correct)
        {
            try
            {

                login.Login_Page(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnProfile");
                GetElement(null, By.CssSelector("profile-chip[style]"), By.CssSelector("div.profile img.profile-image")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);


                SelectProfileMenuOption("Individual Membership");
                System.Threading.Thread.Sleep(DelayScreenChange);

                GetElementWithText(null, By.CssSelector("div.mat-radio-label-content"), "Membership Organization One").Click();

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                GetElementWithText(null, By.CssSelector("mat-radio-button.mat-radio-button"), "Membership Dues Product One").Click();

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                GetElementWithText(null, By.CssSelector("span.mat-checkbox-label"), "Chapter 1").Click();

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                var toyItem = GetElementWithText(null, By.CssSelector("span.mat-checkbox-label"), "toy");
                ScrollIntoView(toyItem);
                toyItem.Click();

                if (IsGreen)
                {
                    var textClickHere = GetElementWithText(null, By.CssSelector("label.mat-form-field-label"), "Click here to select");
                    ScrollIntoView(textClickHere);
                    textClickHere.Click();

                    WaitUntilElementVisible(By.CssSelector("input[Placeholder='Click here to select']")).SendKeys("a");

                    WaitUntilElementExists(By.CssSelector("span.mat-option-text")).Click();
                }

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnNext");
                GetElementWithText(null, By.CssSelector("button.button-blue"), "Next").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnContinueToCart");
                GetElementWithText(null, By.CssSelector("button.button-white"), "Continue to Cart").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("SelectingCheckout");
                WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("GoingToCheckout");
                PayLaterCheckout();
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
        public void Membership_Dues3634(String Correct)
        {
            try
            {

                login.Login_Page(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnProfile");
                GetElement(null, By.CssSelector("profile-chip[style]"), By.CssSelector("div.profile img.profile-image")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);


                SelectProfileMenuOption("Individual Membership");
                System.Threading.Thread.Sleep(DelayScreenChange);

                GetElementWithText(null, By.CssSelector("div.mat-radio-label-content"), "Membership Organization One").Click();

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                GetElementWithText(null, By.CssSelector("div.mat-radio-label-content"), "Membership Dues Product One").Click();

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                GetElementWithText(null, By.CssSelector("span.mat-checkbox-label"), "Chapter 1").Click();

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                if (IsGreen)
                {
                    var textClickHere = GetElementWithText(null, By.CssSelector("label.mat-form-field-label"), "Click here to select");
                    ScrollIntoView(textClickHere);
                    textClickHere.Click();

                    WaitUntilElementVisible(By.CssSelector("input[Placeholder='Click here to select']")).SendKeys("a");

                    WaitUntilElementExists(By.CssSelector("span.mat-option-text")).Click();
                }

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("SelectAdd1");
                WaitUntilElementExists(By.CssSelector("button[data-test='product-select-button-1']")).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                WaitUntilElementExists(By.CssSelector("button[data-test='product-select-button-2']")).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnNext");
                GetElementWithText(null, By.CssSelector("button.button-blue"), "Next").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnNext");
                WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnContinueToCart");
                GetElementWithText(null, By.CssSelector("button.button-white"), "Continue to Cart").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("SelectingCheckout");
                WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("GoingToCheckout");
                PayLaterCheckout();


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