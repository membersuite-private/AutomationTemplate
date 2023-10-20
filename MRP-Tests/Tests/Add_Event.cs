using MRPTests.Config;
using MRPTests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;
using System.Runtime.Remoting.Lifetime;
using System.Threading;

namespace MRPTests.Tests
{
    class Add_Event : MrpTestBase
    {
        private IWebElement GetEvent(string eventName)
        {
            WaitUntilElementExists(By.CssSelector("div.event-name"));
            var eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), eventName);
            if (eventItem == null)
            {
                ScrollView(400);
                Thread.Sleep(DelayWaitOnSelection);
                eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), eventName);
                if (eventItem == null)
                {
                    ScrollView(400);
                    Thread.Sleep(DelayWaitOnSelection);
                    eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), eventName);
                }
            }
            if (eventItem != null)
                ScrollIntoView(eventItem);
            return eventItem;
        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void Add_Events(String Correct)
        {
            try
            {
                Login login = new Login(); 
                login.Login_Page(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                string timestampStr = DateTime.Now.ToString("yyyyMMddHHmmss");

                SelectMenuItem("ClickOnEventsTab", "Events", "Browse Events");
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectEvents");
                var eventItem = GetEvent("Event Type 1028 GROUP");
                eventItem.Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnRegister");
                WaitUntilElementExists(By.CssSelector(Events_locator.Register)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var role1 = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (role1 != null)
                {
                    ScrollIntoView(role1);
                    System.Threading.Thread.Sleep(DelayPrompt);
                    role1.Click();
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                var submit1 = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                if (submit1 != null)
                {
                    ScrollIntoView(submit1);
                    submit1.Click();
                }
                System.Threading.Thread.Sleep(DelayScreenChange);


                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email2);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var roleElement = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (roleElement != null)
                {
                    ScrollIntoView(roleElement);
                    roleElement.Click();
                }
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                try
                {
                    var submitBtn = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                    if (submitBtn != null)
                    {
                        ScrollIntoView(submitBtn);
                        submitBtn.Click();
                    }
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
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
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
                    SetStepName("SelectPackage1");
                    WaitUntilElementExists(By.CssSelector(Events_locator.select_contact1)).Click();
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectPackage2");
                    if (IsBlue)
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-3']")).Click();
                    else if (IsGreen)
                    {
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-3']")).Click();
                    }
                    else
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-3']")).Click();
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
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.XPath(Events_locator._2nd_nxt_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                if (IsGreen)
                {
                    WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                else
                {
                    try
                    {
                        SetStepName("EnterAge");
                        IWebElement element1 = WaitUntilElementExists(By.CssSelector(Events_locator.enter_age1));

                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("arguments[0].value='" + 20 + "';", element1);

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
                        IWebElement element2 = WaitUntilElementExists(By.CssSelector(Events_locator.down_arrow));
                        System.Threading.Thread.Sleep(DelayPrompt);
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("arguments[0].click();", element2);

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
                        SetStepName("EnterAge2");
                        IWebElement element3 = WaitUntilElementExists(By.CssSelector(Events_locator.enter_age2));

                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("arguments[0].value='" + 10 + "';", element3);

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
                        SetStepName("SelectNextButton");
                        WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);

                        SetStepName("SelectNextButton");
                        WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);
                    }
                    catch (Exception ex)
                    {
                        TestError(ex);
                        Assert.IsTrue(false);
                    }
                }
                if (IsBlue)
                {
                    SetStepName("SelectNextButton");
                    WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                try
                {
                    SetStepName("ClickAddToCart");
                    WaitUntilElementExists(By.CssSelector(Events_locator.Addcart)).Click();
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
                    SetStepName("ClickOnCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    SetStepName("GoingToCheckout");
                    PayLaterCheckout();
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
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
        public void Add_Events3736(String Correct)
        {
            try
            {
                Login login = new Login(); 
                login.Login_Page(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                string timestampStr = DateTime.Now.ToString("yyyyMMddHHmmss");

                SelectMenuItem("ClickOnEventsTab", "Events", "Browse Events");
                Thread.Sleep(DelayScreenChange*2);

                SetStepName("SelectEvents");
                WaitUntilElementExists(By.CssSelector("div.event-name"));
                var eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), "3736 sessions event");
                if (eventItem == null)
                {
                    ScrollView(400);
                    Thread.Sleep(DelayWaitOnSelection);
                    eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), "3736 sessions event");
                    if (eventItem == null)
                    {
                        ScrollView(400);
                        Thread.Sleep(DelayWaitOnSelection);
                        eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), "3736 sessions event");
                    }
                }
                ScrollIntoView(eventItem);
                eventItem.Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnRegister");
                WaitUntilElementExists(By.CssSelector(Events_locator.Register)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var role1 = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (role1 != null)
                {
                    ScrollIntoView(role1);
                    System.Threading.Thread.Sleep(DelayPrompt);
                    role1.Click();
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                var submit1 = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                if (submit1 != null)
                {
                    ScrollIntoView(submit1);
                    submit1.Click();
                }
                System.Threading.Thread.Sleep(DelayScreenChange);


                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email2);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var roleElement = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (roleElement != null)
                {
                    ScrollIntoView(roleElement);
                    roleElement.Click();
                }
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                try
                {
                    var submitBtn = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                    if (submitBtn != null)
                    {
                        ScrollIntoView(submitBtn);
                        submitBtn.Click();
                    }
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
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
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
                    SetStepName("SelectPackage");
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-0']")).Click();
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-2']")).Click();
                       
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
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.XPath(Events_locator._2nd_nxt_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection *2);

                if (IsGreen)
                {
                    WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                else
                {
                    try
                    {
                        SetStepName("EnterWriteApples");
                        var divExpPanels = GetElements(null, By.CssSelector("section.bottom-space"));
                        if (divExpPanels != null)
                        {
                            var user1Panel = divExpPanels.First();
                            var placholder1 = GetElement(user1Panel, By.CssSelector("mat-placeholder"));
                            placholder1.Click();
                            var edit1 = GetElement(user1Panel, By.CssSelector("input[data-test='question-0']"));
                            edit1.Clear();
                            edit1.SendKeys("write apples");
                            var cbox1 = GetElement(user1Panel, By.CssSelector("div.mat-checkbox-inner-container"));
                            cbox1.Click();

                            var user2Panel = divExpPanels.Skip(1).First();
                            var expander2 = GetElement(user2Panel, By.CssSelector("span.mat-expansion-indicator"));
                            expander2.Click(); 
                            System.Threading.Thread.Sleep(DelayPrompt);
                            var placholder2 = GetElement(user2Panel, By.CssSelector("mat-placeholder"));
                            placholder2.Click();
                            var edit2 = GetElement(user2Panel, By.CssSelector("input.mat-input-element"));
                            edit2.Clear();
                            edit2.SendKeys("write apples");
                            var cbox2 = GetElement(user2Panel, By.CssSelector("div.mat-checkbox-inner-container"));
                            cbox2.Click();
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
                        SetStepName("SelectNextButton");
                        WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);

                        SetStepName("SelectNextButton");
                        WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);

                    }
                    catch (Exception ex)
                    {
                        TestError(ex);
                        Assert.IsTrue(false);
                    }
                }


                SetStepName("SelectNextButton");
                GetElementWithText(null, By.CssSelector("button.button-blue"), "Next").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                try
                {
                    SetStepName("ClickAddToCart");
                    WaitUntilElementExists(By.CssSelector(Events_locator.Addcart)).Click();
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
                    SetStepName("ClickOnCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    SetStepName("GoingToCheckout");
                    PayLaterCheckout();
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
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
        public void OrgAdd_Events3736(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_OrgPage(Correct); 
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                string timestampStr = DateTime.Now.ToString("yyyyMMddHHmmss");

                SelectMenuItem("ClickOnEventsTab", "Events", "Browse Events");
                Thread.Sleep(DelayScreenChange * 2);

                SetStepName("SelectEvents");
                WaitUntilElementExists(By.CssSelector("div.event-name"));
                var eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), "3736 sessions event");
                if (eventItem == null)
                {
                    ScrollView(400);
                    Thread.Sleep(DelayWaitOnSelection);
                    eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), "3736 sessions event");
                    if (eventItem == null)
                    {
                        ScrollView(400);
                        Thread.Sleep(DelayWaitOnSelection);
                        eventItem = GetElementWithText(null, By.CssSelector("div.event-name"), "3736 sessions event");
                    }
                }
                ScrollIntoView(eventItem);
                eventItem.Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnRegister");
                WaitUntilElementExists(By.CssSelector(Events_locator.Register)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var role1 = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (role1 != null)
                {
                    ScrollIntoView(role1);
                    System.Threading.Thread.Sleep(DelayPrompt);
                    role1.Click();
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                var submit1 = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                if (submit1 != null)
                {
                    ScrollIntoView(submit1);
                    submit1.Click();
                }
                System.Threading.Thread.Sleep(DelayScreenChange);


                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email2);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var roleElement = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (roleElement != null)
                {
                    ScrollIntoView(roleElement);
                    roleElement.Click();
                }
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                try
                {
                    var submitBtn = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                    if (submitBtn != null)
                    {
                        ScrollIntoView(submitBtn);
                        submitBtn.Click();
                    }
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
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
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
                    SetStepName("SelectPackage");
                    WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-0']")).Click();
                    WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-2']")).Click();

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
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.XPath(Events_locator._2nd_nxt_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection * 2);

                if (IsGreen)
                {
                    WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                else
                {
                    try
                    {
                        SetStepName("EnterWriteApples");
                        var divExpPanels = GetElements(null, By.CssSelector("section.bottom-space"));
                        if (divExpPanels != null)
                        {
                            var user1Panel = divExpPanels.First();
                            var placholder1 = GetElement(user1Panel, By.CssSelector("mat-placeholder"));
                            placholder1.Click();
                            var edit1 = GetElement(user1Panel, By.CssSelector("input[data-test='question-0']"));
                            edit1.Clear();
                            edit1.SendKeys("write apples");
                            var cbox1 = GetElement(user1Panel, By.CssSelector("div.mat-checkbox-inner-container"));
                            cbox1.Click();

                            var user2Panel = divExpPanels.Skip(1).First();
                            var expander2 = GetElement(user2Panel, By.CssSelector("span.mat-expansion-indicator"));
                            expander2.Click();
                            System.Threading.Thread.Sleep(DelayPrompt);
                            var placholder2 = GetElement(user2Panel, By.CssSelector("mat-placeholder"));
                            placholder2.Click();
                            var edit2 = GetElement(user2Panel, By.CssSelector("input.mat-input-element"));
                            edit2.Clear();
                            edit2.SendKeys("write apples");
                            var cbox2 = GetElement(user2Panel, By.CssSelector("div.mat-checkbox-inner-container"));
                            cbox2.Click();
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
                        SetStepName("SelectNextButton");
                        WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);

                        SetStepName("SelectNextButton");
                        WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);

                    }
                    catch (Exception ex)
                    {
                        TestError(ex);
                        Assert.IsTrue(false);
                    }
                }


                SetStepName("SelectNextButton");
                GetElementWithText(null, By.CssSelector("button.button-blue"), "Next").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                try
                {
                    SetStepName("ClickAddToCart");
                    WaitUntilElementExists(By.CssSelector(Events_locator.Addcart)).Click();
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
                    SetStepName("ClickOnCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    SetStepName("GoingToCheckout");
                    PayLaterCheckout();
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
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
        public void Add_Events3766(String Correct)
        {
            try
            {
                Login login = new Login(); 
                login.Login_Page(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                string timestampStr = DateTime.Now.ToString("yyyyMMddHHmmss");

                SelectMenuItem("ClickOnEventsTab", "Events", "Browse Events");
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectEvents");
                var eventItem = GetEvent("Example 1");
                eventItem.Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnRegister");
                WaitUntilElementExists(By.CssSelector(Events_locator.Register)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var role1 = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (role1 != null)
                {
                    ScrollIntoView(role1);
                    System.Threading.Thread.Sleep(DelayPrompt);
                    role1.Click();
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                var submit1 = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                if (submit1 != null)
                {
                    ScrollIntoView(submit1);
                    submit1.Click();
                }
                System.Threading.Thread.Sleep(DelayScreenChange);


                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email2);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var roleElement = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (roleElement != null)
                {
                    ScrollIntoView(roleElement);
                    roleElement.Click();
                }
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                try
                {
                    var submitBtn = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                    if (submitBtn != null)
                    {
                        ScrollIntoView(submitBtn);
                        submitBtn.Click();
                    }
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
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
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
                    SetStepName("SelectPackage1");
                    WaitUntilElementExists(By.CssSelector(Events_locator.select_contact1)).Click();
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectPackage");
                    if (IsBlue)
                    {
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-0']")).Click();
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-1']")).Click();
                    }
                    else if (IsGreen)
                        WaitUntilElementExists(By.CssSelector(Events_locator.select_contact2)).Click();
                    else
                        WaitUntilElementExists(By.CssSelector(Events_locator.select_contact2)).Click();
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
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.XPath(Events_locator._2nd_nxt_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                try
                {
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.XPath(Events_locator._2nd_nxt_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("SelectAdd1");
                WaitUntilElementExists(By.CssSelector("button[data-test='product-select-button-0']")).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("SelectNextButton");
                GetElementWithText(null, By.CssSelector("button.button-blue"), "Next").Click();
                System.Threading.Thread.Sleep(DelayScreenChange *2);
                
                SetStepName("ClickAddToCart");
                GetElementWithText(null, By.CssSelector("button.button-blue"), "Add to Cart").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnCheckout");
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
        public void Add_OrgEvents3766(String Correct)
        {
            try
            {
                Login login = new Login(); 
                login.Login_OrgPage(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                string timestampStr = DateTime.Now.ToString("yyyyMMddHHmmss");

                SelectMenuItem("ClickOnEventsTab", "Events", "Browse Events");
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectEvents");
                WaitUntilElementExists(By.CssSelector(Events_locator.select_events));
                ScrollView(800);
                System.Threading.Thread.Sleep(DelayScreenChange);
                var textExample1 = GetElementWithText(null, By.CssSelector("li.event-row"), "Example 1");
                ScrollIntoView(textExample1);
                textExample1.Click();

                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnRegister");
                WaitUntilElementExists(By.CssSelector(Events_locator.Register)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var role1 = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (role1 != null)
                {
                    ScrollIntoView(role1);
                    System.Threading.Thread.Sleep(DelayPrompt);
                    role1.Click();
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                var submit1 = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                if (submit1 != null)
                {
                    ScrollIntoView(submit1);
                    submit1.Click();
                }
                System.Threading.Thread.Sleep(DelayScreenChange);


                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email2);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var roleElement = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (roleElement != null)
                {
                    ScrollIntoView(roleElement);
                    roleElement.Click();
                }
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                try
                {
                    var submitBtn = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                    if (submitBtn != null)
                    {
                        ScrollIntoView(submitBtn);
                        submitBtn.Click();
                    }
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
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
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
                    SetStepName("SelectContact1");
                    WaitUntilElementExists(By.CssSelector(Events_locator.select_contact1)).Click();
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectPackage");
                    if (IsBlue)
                    {
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-0']")).Click();
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-1']")).Click();
                    }
                    else if (IsGreen)
                    {
                        WaitUntilElementExists(By.CssSelector(Events_locator.select_contact2)).Click();
                    }
                    else
                        WaitUntilElementExists(By.CssSelector(Events_locator.select_contact2)).Click();
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
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.XPath(Events_locator._2nd_nxt_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                try
                {
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.XPath(Events_locator._2nd_nxt_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("SelectAdd1");
                WaitUntilElementExists(By.CssSelector("button[data-test='product-select-button-0']")).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("SelectNextButton");
                GetElementWithText(null, By.CssSelector("button.button-blue"), "Next").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);
                try
                {
                    //Verify previous selections were added
                    SetStepName("ClickAddToCart");
                    WaitUntilElementExists(By.CssSelector(Events_locator.Addcart)).Click();
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
                    SetStepName("ClickOnCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    SetStepName("GoingToCheckout");
                    PayLaterCheckout();
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
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
        public void OrgAdd_Events(String Correct)
        {
            
            {
                Login login = new Login();
                login.Login_OrgPage(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                string timestampStr = DateTime.Now.ToString("yyyyMMddHHmmss");

                SelectMenuItem("ClickOnEventsTab", "Events", "Browse Events");
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectEvents");
                var eventItem = GetEvent("Event Type 1028 GROUP");
                eventItem.Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnRegister");
                WaitUntilElementExists(By.CssSelector(Events_locator.Register)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var role1 = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (role1 != null)
                {
                    ScrollIntoView(role1);
                    System.Threading.Thread.Sleep(DelayPrompt);
                    role1.Click();
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                var submit1 = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                if (submit1 != null)
                {
                    ScrollIntoView(submit1);
                    submit1.Click();
                }
                System.Threading.Thread.Sleep(DelayScreenChange);


                SetStepName("EnterEmailLastFirstName");
                WaitUntilElementExists(By.CssSelector(Events_locator.email)).SendKeys("email" + timestampStr + s_k_values.email2);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.lastname)).SendKeys(s_k_values.contact_lname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                WaitUntilElementExists(By.CssSelector(Events_locator.firstname)).SendKeys(s_k_values.contact_fname + timestampStr);
                System.Threading.Thread.Sleep(DelayPrompt);

                SetStepName("SelectRole");
                var roleElement = WaitUntilElementExists(By.CssSelector(Events_locator.role));
                if (roleElement != null)
                {
                    ScrollIntoView(roleElement);
                    roleElement.Click();
                }
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementExists(By.CssSelector(Events_locator.select_role)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("ClickOnSubmit");
                try
                {
                    var submitBtn = WaitUntilElementExists(By.CssSelector(Events_locator.submitbtn));
                    if (submitBtn != null)
                    {
                        ScrollIntoView(submitBtn);
                        submitBtn.Click();
                    }
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
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
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
                    SetStepName("SelectPackage1");
                    WaitUntilElementExists(By.CssSelector(Events_locator.select_contact1)).Click();
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectPackage2");
                    if (IsBlue)
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-3']")).Click();
                    else if (IsGreen)
                    {
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-3']")).Click();
                    }
                    else
                        WaitUntilElementExists(By.CssSelector("button[data-test='package-select-button-3']")).Click();
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
                    SetStepName("ClickOnNext");
                    WaitUntilElementExists(By.XPath(Events_locator._2nd_nxt_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                if (IsGreen)
                {
                    WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    WaitUntilElementExists(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                else
                {
                    try
                    {
                        SetStepName("EnterAge");
                        IWebElement element1 = WaitUntilElementExists(By.CssSelector(Events_locator.enter_age1));

                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("arguments[0].value='" + 20 + "';", element1);

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
                        IWebElement element2 = WaitUntilElementExists(By.CssSelector(Events_locator.down_arrow));
                        System.Threading.Thread.Sleep(DelayPrompt);
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("arguments[0].click();", element2);

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
                        SetStepName("EnterAge2");
                        IWebElement element3 = WaitUntilElementExists(By.CssSelector(Events_locator.enter_age2));

                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("arguments[0].value='" + 10 + "';", element3);

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
                        SetStepName("SelectNextButton");
                        WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);

                        SetStepName("SelectNextButton");
                        WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);
                    }
                    catch (Exception ex)
                    {
                        TestError(ex);
                        Assert.IsTrue(false);
                    }
                }
                if (IsBlue)
                {
                    SetStepName("SelectNextButton");
                    WaitUntilElementExists(By.CssSelector(Events_locator.next_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                try
                {
                    SetStepName("ClickAddToCart");
                    WaitUntilElementExists(By.CssSelector(Events_locator.Addcart)).Click();
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
                    SetStepName("ClickOnCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    SetStepName("GoingToCheckout");
                    PayLaterCheckout();
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    Assert.IsTrue(false);
                }
            }
        }
    }
}