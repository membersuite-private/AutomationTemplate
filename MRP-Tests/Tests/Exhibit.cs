using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MRPTests.Config;
using MRPTests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;
using System.Runtime.Remoting.Lifetime;

namespace MRPTests.Tests
{
    public class Exhibit : MrpTestBase
    {
        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void RegisterForExhibit(String Correct)
        {
            try
            {
                Join join = new Join();
                join.JoinViaMRP(Correct);
                TestId = join.TestId;

                SetStepName("ClickOnEventsMenuItem");
                var menuItems = GetElements(null, By.CssSelector("span.inner-text"));
                if (menuItems != null)
                {
                    foreach(var menuItem in menuItems)
                    {
                        if (menuItem.Text.Contains("Events"))
                        {
                            menuItem.Click();
                            break;
                        }
                    }
                }
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnBrowseEvents");
                WaitUntilElementExists(By.CssSelector(Events_locator.browse_events)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                WaitUntilElementVisible(By.CssSelector("div.event-name"));
                SetStepName("SelectEvent");
                var events = GetElements(null, By.CssSelector("div.event-name"));
                if (events != null)
                {
                    foreach(var e in events)
                    {
                        if ((e.Text.StartsWith("Exhibit")) || (e.Text.StartsWith("Free Exhibit")))
                        {
                            ScrollIntoView(e);
                            e.Click();
                            break;
                        }
                    }
                }
                System.Threading.Thread.Sleep(DelayScreenChange);

                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange * 2);

                SetStepName("EnterBoothInfo");
                var navStep = WaitUntilElementVisible(By.CssSelector("div.nav-step span"));
                if (navStep != null)
                { 
                    if (navStep.Text.StartsWith("Booth Selection"))
                    {
                        if (ElementExist(By.CssSelector("span.booth-name")))
                        {
                            var spanE = WaitUntilElementVisible(By.CssSelector("span.booth-name"));
                            if (spanE.Text.Contains("Booth Name"))
                            {
                                var element = WaitUntilElementVisible(By.CssSelector("mat-radio-group"));
                                element.Click();

                                var radioButtons = GetElements(null, By.CssSelector("mat-radio-button"));
                                if ((radioButtons != null) && (radioButtons.Count > 0))
                                {
                                    radioButtons.First().Click();
                                    System.Threading.Thread.Sleep(DelayScreenChange);
                                }
                            }
                        }
                    }
                }
                System.Threading.Thread.Sleep(DelayScreenChange);

                var spanBoothName = WaitUntilElementVisible(By.CssSelector("span.booth-name"));
                if (spanBoothName.Text.Contains("Booth Type"))
                {
                    SetStepName("EnterBoothType");
                    var boothTypes = GetElements(null, By.CssSelector("div.mat-radio-container"));
                    if ((boothTypes != null) && (boothTypes.Count > 0))
                        boothTypes.First().Click();

                    var choiceCombos = GetElements(null, By.CssSelector("mat-select"));
                    if ((choiceCombos != null) && (choiceCombos.Count > 0))
                    {
                        for (int ctr = 0; ctr < 3 && ctr < choiceCombos.Count; ctr++)
                        {
                            ScrollIntoView(choiceCombos[ctr]);
                            choiceCombos[ctr].Click();
                            System.Threading.Thread.Sleep(DelayPrompt);

                            var matOptions = GetElements(null, By.CssSelector("mat-option"));
                            if ((matOptions != null) && (matOptions.Count > ctr))
                            {
                                ScrollIntoView(matOptions[ctr]);
                                matOptions[ctr].Click();
                                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                            }
                        }
                    }

                    WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }


                if (ElementExist(By.CssSelector("span.mat-form-field-label-wrapper")))
                {
                    SetStepName("EnterName");
                    var inputElement = WaitUntilElementVisible(By.CssSelector("span.mat-form-field-label-wrapper"));
                    if (inputElement.Text.Contains("Name"))
                    {
                        inputElement.Click();
                        inputElement = WaitUntilElementVisible(By.CssSelector("input[data-test='question-0']"));
                        inputElement.Clear();
                        inputElement.SendKeys("Test Name");
                        System.Threading.Thread.Sleep(DelayPrompt);
                    }

                    WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                }
                try
                {
                    SetStepName("ContinueTwice");
                    WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);

                    WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange * 2);
                }
                catch { }

                if (ElementExist(By.CssSelector("mat-dialog-container")))
                {
                    var dialog = WaitUntilElementVisible(By.CssSelector("mat-dialog-container"));
                    var buttons = GetElements(dialog, By.CssSelector("button.button-blue"));
                    if (buttons != null)
                    {
                        buttons.First().Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        SetStepName("EnterExhibitorInfo");
                        var contact = WaitUntilElementVisible(By.CssSelector("a.exhibitor-task-list"));
                        ScrollIntoView(contact);
                        contact.Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);

                        WaitUntilElementVisible(By.CssSelector("mat-form-field.add-exhibit-field")).Click();
                        var contactOptions = GetElements(null, By.CssSelector("mat-option"));
                        if ((contactOptions != null) && (contactOptions.Count > 0))
                            contactOptions.First().Click();

                        var title = WaitUntilElementVisible(By.CssSelector("input[name='title']"));
                        ScrollIntoView(title);
                        title.Clear();
                        title.SendKeys("Test Title");

                        var firstname = WaitUntilElementVisible(By.CssSelector("input[name='first-name']"));
                        ScrollIntoView(firstname);
                        firstname.Clear();
                        firstname.SendKeys("Test FirstName");

                        var lastname = WaitUntilElementVisible(By.CssSelector("input[name='last-name']"));
                        ScrollIntoView(lastname);
                        lastname.Clear();
                        lastname.SendKeys("Test LastName");

                        var email = WaitUntilElementVisible(By.CssSelector("input[name='email']"));
                        ScrollIntoView(email);
                        email.Clear();
                        email.SendKeys(join.EmailAddress);

                        var workPhone = WaitUntilElementVisible(By.CssSelector("input[name='work-phone']"));
                        ScrollIntoView(workPhone);
                        workPhone.Clear();
                        workPhone.SendKeys("9185551212");

                        WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                        Assert.IsTrue(true);
                    }
                }
                else
                {
                    try
                    {
                        SetStepName("ContinueTwiceAgain");
                        WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);

                        WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                        System.Threading.Thread.Sleep(DelayScreenChange);
                    }
                    catch { }

                   

                    SetStepName("GoingToCheckout");
                    PayLaterCheckout();

                }
            }
            catch(Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false, ex.Message);
            }
        }
    }
}
