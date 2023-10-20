using MRPTests.Config;
using MRPTests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MRPTests.Tests
{
    [TestClass]
    class MyProfile : MrpTestBase
    {

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void Profile(String Correct)
        {
            try
            {
                Login login = new Login(this);
                login.Login_Page(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnProfileIcon");
                GetElement(null, By.CssSelector("profile-chip[style]"), By.CssSelector("div.profile img.profile-image")).Click();

                SetStepName("ClickOnMyProfile");
                SelectProfileMenuOption("My Profile");
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnEditButton");
                System.Threading.Thread.Sleep(DelayWaitOnMyAccount);
                WaitUntilElementVisible(By.XPath(locator_profile.edit_btn)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterLastName");
                WaitUntilElementExists(By.XPath(locator_profile.last_name)).Clear();
                WaitUntilElementExists(By.XPath(locator_profile.last_name)).SendKeys(s_k_values.lastname);

                SetStepName("RemoveEnterPhone");
                try
                {
                    IWebElement remove_phone = WaitUntilElementClickable(By.XPath(locator_profile.remove_phone));
                    if (remove_phone.Displayed)
                    {
                        remove_phone.Click();
                    }
                }
                catch { }

                WaitUntilElementClickable(By.CssSelector(locator_profile.phone_radio)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                WaitUntilElementVisible(By.Name(locator_profile.phone_num)).SendKeys(s_k_values.phone_number);
                WaitUntilElementExists(By.CssSelector(locator_profile.save_phone)).Click();
                System.Threading.Thread.Sleep(500);
                try
                {
                    WaitUntilElementVisible(By.CssSelector(locator_profile.remove_address)).Click();
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                }
                catch { }

                SetStepName("Address");
                if (IsProduction)
                    WaitUntilElementVisible(By.CssSelector(locator_profile.address_radio)).Click();
                else
                {
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
                                var addrBtn = addrButtons.First();
                                var divAddr = GetElement(addrBtn, By.CssSelector("div.mat-radio-container"));
                                divAddr.Click();
                                Thread.Sleep(DelayWaitOnSelection);
                            }

                        }
                    }
                }

                System.Threading.Thread.Sleep(DelayPrompt);
                SetStepName("EnterAddress");
                WaitUntilElementVisible(By.CssSelector(locator_profile.address_field)).SendKeys(s_k_values.address);
                WaitUntilElementVisible(By.CssSelector(locator_profile.city_field)).SendKeys(s_k_values.city);
                IWebElement state = WaitUntilElementVisible(By.CssSelector(locator_profile.state_select));
                state.Click();
                IWebElement dropdown_value = WaitUntilElementVisible(By.CssSelector(locator_profile.action_locator));
                if (dropdown_value.Displayed)
                {
                    Actions profile = new Actions(driver);
                    profile.MoveToElement(dropdown_value).Click();
                    System.Diagnostics.Debug.WriteLine("  Button  found");
                }
                else
                {

                    System.Diagnostics.Debug.WriteLine("  Button not found");
                }

                WaitUntilElementClickable(By.CssSelector(locator_profile.state_value)).Click();
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementVisible(By.CssSelector(locator_profile.zipcode)).SendKeys(s_k_values.zipcode);
                IWebElement country_select = WaitUntilElementVisible(By.CssSelector(locator_profile.country_select));
                country_select.Click();
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementClickable(By.CssSelector(locator_profile.country_value)).Click();

                SetStepName("ValidAddress");
                WaitUntilElementVisible(By.XPath(locator_profile.validate_address)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);
                                
                if (IsBlue)
                {
                    try
                    {
                        WaitUntilElementVisible(By.CssSelector("input[data-test='question-1']")).Clear();
                        WaitUntilElementVisible(By.CssSelector("input[data-test='question-1']")).SendKeys("25");
                        Thread.Sleep(DelayPrompt);
                    }
                    catch { }
                }

                SetStepName("UpdateProfile");
                WaitUntilElementVisible(By.CssSelector(locator_profile.update_btn)).Click();
                driver.SwitchTo().ActiveElement();
                WaitUntilElementVisible(By.CssSelector(locator_profile.update_profile_btn)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                System.Threading.Thread.Sleep(DelayScreenChange);
                IWebElement assert_txt = WaitUntilElementVisible(By.CssSelector(locator_profile.assert_profile));
                SetStepName("ProfileUpdated");
                NUnit.Framework.Assert.IsTrue(true);
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
        public void OrgProfile(String Correct)
        {
            try
            {
                Login login = new Login(this);
                login.Login_OrgPage(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                WaitUntilElementVisible(By.CssSelector("profile-chip[style]"));
                SetStepName("ClickOnProfileIcon");
                Thread.Sleep(DelayScreenChange);
                GetElement(null, By.CssSelector("profile-chip[style]"), By.CssSelector("div.profile img.profile-image")).Click();

                SetStepName("ClickOnMyProfile");
                SelectProfileMenuOption("My Profile");
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("ClickOnEditButton");
                System.Threading.Thread.Sleep(DelayWaitOnMyAccount);
                WaitUntilElementVisible(By.XPath(locator_profile.edit_btn)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                EnterKeys("orgprofile@yopmail.com", "input[data-test='input-email']", "ChangingEmail");
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("Address");
                WaitUntilElementVisible(By.CssSelector(locator_profile.remove_address)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

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
                            var addrBtn = addrButtons.First();
                            var divAddr = GetElement(addrBtn, By.CssSelector("div.mat-radio-container"));
                            divAddr.Click();
                            Thread.Sleep(DelayWaitOnSelection);
                        }

                    }
                }

                System.Threading.Thread.Sleep(DelayPrompt);
                SetStepName("EnterAddress");
                WaitUntilElementVisible(By.CssSelector(locator_profile.address_field)).SendKeys(s_k_values.address);
                WaitUntilElementVisible(By.CssSelector(locator_profile.city_field)).SendKeys(s_k_values.city);
                WaitUntilElementVisible(By.CssSelector("input[data-test='input-address-line-2']")).SendKeys("SUITE INFO");
                IWebElement state = WaitUntilElementVisible(By.CssSelector(locator_profile.state_select));
                state.Click();
                IWebElement dropdown_value = WaitUntilElementVisible(By.CssSelector(locator_profile.action_locator));
                if (dropdown_value.Displayed)
                {
                    Actions profile = new Actions(driver);
                    profile.MoveToElement(dropdown_value).Click();
                    System.Diagnostics.Debug.WriteLine("  Button  found");
                }
                else
                {

                    System.Diagnostics.Debug.WriteLine("  Button not found");
                }

                WaitUntilElementClickable(By.CssSelector(locator_profile.state_value)).Click();
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementVisible(By.CssSelector(locator_profile.zipcode)).SendKeys(s_k_values.zipcode);
                IWebElement country_select = WaitUntilElementVisible(By.CssSelector(locator_profile.country_select));
                country_select.Click();
                System.Threading.Thread.Sleep(DelayPrompt);
                WaitUntilElementClickable(By.CssSelector(locator_profile.country_value)).Click();

                SetStepName("ValidAddress");
                WaitUntilElementVisible(By.XPath(locator_profile.validate_address)).Click();
                System.Threading.Thread.Sleep(DelayWaitOnSelection);

                SetStepName("UpdateProfile");
                WaitUntilElementVisible(By.CssSelector(locator_profile.update_btn)).Click();
                driver.SwitchTo().ActiveElement();
                WaitUntilElementVisible(By.CssSelector(locator_profile.update_profile_btn)).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                System.Threading.Thread.Sleep(DelayScreenChange);
                IWebElement assert_txt = WaitUntilElementVisible(By.CssSelector(locator_profile.assert_profile));
                SetStepName("ProfileUpdated");
                NUnit.Framework.Assert.IsTrue(true);
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
