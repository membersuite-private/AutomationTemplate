using MRPTests.Config;
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
using MRPTests.Helper;
using Assert = NUnit.Framework.Assert;
using System.Security.Permissions;

namespace MRPTests.Tests
{
    public class MyAccount : MrpTestBase

    {
        Login login = new Login();

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void MyAccount_history(String Correct)
        {
            try
            {
                login.Login_Page(Correct);
                TestId = login.TestId;

                Thread.Sleep(DelayScreenChange);
                SetStepName("ClickProfile");
                GetElement(null, By.CssSelector("profile-chip[style]"), By.CssSelector("div.profile img.profile-image")).Click();
                IWebElement elem1 = WaitUntilElementVisible(By.XPath(general_locators.Dialog));
                if (elem1.Displayed)
                {
                    Actions profile = new Actions(driver);
                    profile.MoveToElement(elem1);
                    System.Diagnostics.Debug.WriteLine("  Button  found");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Button not found");
                }
                SetStepName("ClickOnMyProfile");
                WaitUntilElementExists(By.XPath(general_locators.my_profile)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                var myInfo = WaitUntilElementVisible(By.CssSelector("div.mat-tab-label-content"));
                myInfo.Click();

                var myAccount = WaitUntilElementExists(By.CssSelector(MyAccount_locators.My_Account));
                System.Threading.Thread.Sleep(DelayWaitOnMyAccount);
                myAccount.Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ExpandAccordion");
                WaitUntilElementExists(By.CssSelector(MyAccount_locators.down_accordion)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnOrderId");
                WaitUntilElementExists(By.CssSelector(MyAccount_locators.order_id)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                var printInvoice = WaitUntilElementExists(By.CssSelector(MyAccount_locators.print_invoice));
                if (printInvoice != null)
                {
                    ScrollToTop();
                    SetStepName("PreparingToClickPrintInvoice");
                    printInvoice.Click();
                }
                System.Threading.Thread.Sleep(DelayScreenChange);
                SetStepName("PrintInvoice");
                Assert.IsTrue(true);
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
