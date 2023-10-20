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

namespace MRPTests.Tests
{
    class BrowseStore : MrpTestBase
    {
        public BrowseStore() { }
        public BrowseStore(TestBase testBase)
        {
            BrowserName = testBase.BrowserName;
            TestName = testBase.TestName;
            TestId = testBase.TestId;
        }


        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void AddtoCart(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_Page(Correct);
                TestId = login.TestId;
                System.Threading.Thread.Sleep(DelayScreenChange);

                try
                {
                    SetStepName("ClickOnShop");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.shop)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnBrowseStore");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.browse_store)).Click();

                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("Select1stItemImage");
                    // Need to add a valid image for green
                    if (IsProduction)
                        WaitUntilElementExists(By.CssSelector(Shop_locators.items_select_1st_)).Click();
                   else if (IsGreen)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-c1be-6481-0b405f87779a']")).Click();
                    else
                    {
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-c3be-d748-9d4a55d8c6f2']")).Click();
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnAddToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.Add_tocart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnContinueShopping");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.continue_shopping)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("Select2ndItemImage");
                    // Need to add a valid image for green
                    if (IsProduction)
                        WaitUntilElementClickable(By.CssSelector(Shop_locators.items_select_2nd_)).Click();
                    else if(IsGreen)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-cd70-d844-0b405f876a41']")).Click();

                    else
                    {
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-c039-d848-9a77ea6d7232']")).Click();
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnAddToCartAgain");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.Add_tocart)).Click();
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnContinueToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.continue_cart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectingCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch(Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                SetStepName("GoingToCheckout");
                PayLaterCheckout();
            }
            catch(Exception ex)
            {
                TestError(ex);
                NUnit.Framework.Assert.IsTrue(false);
            }
        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void OrgAddtoCart(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_OrgPage(Correct);
                TestId = login.TestId;
                System.Threading.Thread.Sleep(DelayScreenChange);

                try
                {
                    SetStepName("ClickOnShop");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.shop)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnBrowseStore");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.browse_store)).Click();

                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("Select1stItemImage");
                    // Need to add a valid image for green
                    if (IsProduction)
                        WaitUntilElementExists(By.CssSelector(Shop_locators.items_select_1st_)).Click();
                    else if (IsGreen)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-c1be-6481-0b405f87779a']")).Click();
                    else
                    {
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-c3be-d748-9d4a55d8c6f2']")).Click();
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnAddToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.Add_tocart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnContinueShopping");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.continue_shopping)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("Select2ndItemImage");
                    // Need to add a valid image for green
                    if (IsProduction)
                        WaitUntilElementClickable(By.CssSelector(Shop_locators.items_select_2nd_)).Click();
                    else if (IsGreen)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-cd70-d844-0b405f876a41']")).Click();

                    else
                    {
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-c039-d848-9a77ea6d7232']")).Click();
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnAddToCartAgain");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.Add_tocart)).Click();
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnContinueToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.continue_cart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectingCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                SetStepName("GoingToCheckout");
                PayLaterCheckout();
            }
            catch (Exception ex)
            {
                TestError(ex);
                NUnit.Framework.Assert.IsTrue(false);
            }
        }
        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TestShippingUS(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_Page(Correct);
                TestId = login.TestId;
                System.Threading.Thread.Sleep(DelayScreenChange);

                try
                {
                    SetStepName("ClickOnShop");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.shop)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnBrowseStore");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.browse_store)).Click();

                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("Select1stItemImage");
                    // Need to add a valid image for green
                    if (IsProduction)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.membersuite.com/eb12a7be-0004-c2c7-1b59-0b3fb87d8577/31961/eb12a7be-001c-c77b-d848-e4132fd00497']")).Click();
                    else if (IsGreen)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-c25a-d848-5ad115c50497']")).Click();
                    else
                    {
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-c8ff-d848-9034e7b90497']")).Click();
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnAddToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.Add_tocart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnContinueToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.continue_cart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectingCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }
                SetStepName("SelectShippingAddress");
                WaitUntilElementExists(By.CssSelector("div.new-address")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterShippingAddress");
                try
                {
                    SetStepName("EnterNewAddress");
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).SendKeys("510 Main Street");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")));
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).SendKeys("Wall");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")));
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).SendKeys("57790");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("mat-select[data-test='shipping-country']")));
                    WaitUntilElementVisible(By.CssSelector("mat-select[data-test='shipping-country']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    GetElementWithText(null, By.CssSelector("span.mat-option-text"), "United States").Click();


                    var valButtons = GetElements(null, By.CssSelector("button.add-btn"));
                    if (valButtons != null)
                    {
                        foreach (var valBtn in valButtons)
                        {
                            if (valBtn.Text.Contains("Validate and Save Address"))
                                valBtn.Click();
                        }
                    }
                    System.Threading.Thread.Sleep(1000);
                    if (ElementExist(By.CssSelector("mat-error")))
                    {
                        NUnit.Framework.Assert.IsTrue(false, "Address verification failed");
                    }

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
                    SetStepName("ClickNext");
                    WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                }
                catch { }

                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("SelectShippingMethodCanada");
                GetElementWithText(null, By.CssSelector("div.name"), "Canada").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                if (!ElementExist(By.CssSelector("div.error-title")))
                {
                    NUnit.Framework.Assert.IsTrue(false, "Canada should not be valid");
                }

                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("SelectOrderByShippingMethod");
                GetElementWithText(null, By.CssSelector("div.name"), "Order by Weight").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                if (ElementExist(By.CssSelector("div.error-title")))
                {
                    NUnit.Framework.Assert.IsTrue(false, "Order by Weight should be valid");
                }
                SetStepName("ClickNext");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();

                SetStepName("GoingToCheckout");
                PayLaterCheckout();
            }
            catch (Exception ex)
            {
                TestError(ex);
                NUnit.Framework.Assert.IsTrue(false);
            }
        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TestShippingCanada(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_Page(Correct);
                TestId = login.TestId;
                System.Threading.Thread.Sleep(DelayScreenChange);

                try
                {
                    SetStepName("ClickOnShop");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.shop)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnBrowseStore");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.browse_store)).Click();

                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("Select1stItemImage");
                    // Need to add a valid image for green
                    if (IsProduction)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.membersuite.com/eb12a7be-0004-c2c7-1b59-0b3fb87d8577/31961/eb12a7be-001c-c77b-d848-e4132fd00497']")).Click();
                    else if (IsGreen)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-c25a-d848-5ad115c50497']")).Click();
                    else
                    {
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-c8ff-d848-9034e7b90497']")).Click();
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnAddToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.Add_tocart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnContinueToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.continue_cart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectingCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }
                SetStepName("SelectShippingAddress");
                WaitUntilElementExists(By.CssSelector("div.new-address")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterShippingAddress");
                try
                {
                    SetStepName("EnterNewAddress");
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).SendKeys("500 King St W");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")));
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).SendKeys("Toronto");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")));
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).SendKeys("M5V1L9");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("mat-select[data-test='shipping-country']")));
                    WaitUntilElementVisible(By.CssSelector("mat-select[data-test='shipping-country']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    GetElementWithText(null, By.CssSelector("span.mat-option-text"), "Canada").Click();


                    var valButtons = GetElements(null, By.CssSelector("button.add-btn"));
                    if (valButtons != null)
                    {
                        foreach (var valBtn in valButtons)
                        {
                            if (valBtn.Text.Contains("Validate and Save Address"))
                                valBtn.Click();
                        }
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    if (ElementExist(By.CssSelector("mat-error")))
                    {
                        NUnit.Framework.Assert.IsTrue(false, "Address verification failed");
                    }

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
                    SetStepName("ClickNext");
                    WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                }
                catch { }

                System.Threading.Thread.Sleep(DelayScreenChange);
                SetStepName("SelectOrderByShippingMethod");
                GetElementWithText(null, By.CssSelector("div.name"), "Order by Weight").Click();
                System.Threading.Thread.Sleep(3000);

                if (!ElementExist(By.CssSelector("div.error-title")))
                {
                    NUnit.Framework.Assert.IsTrue(false, "Order by Weight should not be valid");
                }

                SetStepName("SelectShippingMethodCanada");
                GetElementWithText(null, By.CssSelector("div.name"), "Canada").Click();
                System.Threading.Thread.Sleep(3000);

                if (ElementExist(By.CssSelector("div.error-title")))
                {
                    NUnit.Framework.Assert.IsTrue(false, "Canada should be valid");
                }

                SetStepName("ClickNext");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();

                SetStepName("GoingToCheckout");
                PayLaterCheckout();
            }
            catch (Exception ex)
            {
                TestError(ex);
                NUnit.Framework.Assert.IsTrue(false);
            }
        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TestShippingUK(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_Page(Correct);
                TestId = login.TestId;
                System.Threading.Thread.Sleep(DelayScreenChange);

                try
                {
                    SetStepName("ClickOnShop");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.shop)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnBrowseStore");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.browse_store)).Click();

                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("Select1stItemImage");
                    // Need to add a valid image for green
                    if (IsProduction)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.membersuite.com/eb12a7be-0004-c2c7-1b59-0b3fb87d8577/31961/eb12a7be-001c-c77b-d848-e4132fd00497']")).Click();
                    else if (IsGreen)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-c25a-d848-5ad115c50497']")).Click();
                    else
                    {
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-c8ff-d848-9034e7b90497']")).Click();
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnAddToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.Add_tocart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnContinueToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.continue_cart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectingCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }
                SetStepName("SelectShippingAddress");
                WaitUntilElementExists(By.CssSelector("div.new-address")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterShippingAddress");
                try
                {
                    SetStepName("EnterNewAddress");
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).SendKeys("11 Old Market Way");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")));
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).SendKeys("Moreton-In-Marsh");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")));
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).SendKeys("GL56 0AJ");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("mat-select[data-test='shipping-country']")));
                    WaitUntilElementVisible(By.CssSelector("mat-select[data-test='shipping-country']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    var cntry = GetElementWithText(null, By.CssSelector("span.mat-option-text"), "United Kingdom");
                    ScrollIntoView(cntry);
                    cntry.Click();

                    System.Threading.Thread.Sleep(DelayScreenChange);

                    var valButtons = GetElements(null, By.CssSelector("button.add-btn"));
                    if (valButtons != null)
                    {
                        foreach (var valBtn in valButtons)
                        {
                            if (valBtn.Text.Contains("Validate and Save Address"))
                                valBtn.Click();
                        }
                    }
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    if (ElementExist(By.CssSelector("mat-error")))
                    {
                        NUnit.Framework.Assert.IsTrue(false, "Address verification failed");
                    }

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
                    SetStepName("ClickNext");
                    WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                }
                catch { }

                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("SelectOrderByShippingMethod");
                GetElementWithText(null, By.CssSelector("div.name"), "Order by Weight").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                if (!ElementExist(By.CssSelector("div.error-title")))
                {
                    NUnit.Framework.Assert.IsTrue(false, "Order by Weight should not be valid");
                }

                SetStepName("SelectShippingMethodUnitedKingdom");
                GetElementWithText(null, By.CssSelector("div.name"), "Intl Shipping").Click();
                System.Threading.Thread.Sleep(3000);

                if (ElementExist(By.CssSelector("div.error-title")))
                {
                    NUnit.Framework.Assert.IsTrue(false, "International Shipping should be valid");
                }

                SetStepName("ClickNext");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();

                SetStepName("GoingToCheckout");
                PayLaterCheckout();
            }
            catch (Exception ex)
            {
                TestError(ex);
                NUnit.Framework.Assert.IsTrue(false);
            }
        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void TestShippingQLD(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_Page(Correct);
                TestId = login.TestId;
                System.Threading.Thread.Sleep(DelayScreenChange);

                try
                {
                    SetStepName("ClickOnShop");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.shop)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnBrowseStore");
                    WaitUntilElementClickable(By.CssSelector(Shop_locators.browse_store)).Click();

                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("Select1stItemImage");
                    // Need to add a valid image for green
                    if (IsProduction)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.membersuite.com/eb12a7be-0004-c2c7-1b59-0b3fb87d8577/31961/eb12a7be-001c-c77b-d848-e4132fd00497']")).Click();
                    else if (IsGreen)
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images.financial.membersuite.com/a3af95af-0004-cc04-e8d3-0b3fb7868f98/31805/a3af95af-001c-c25a-d848-5ad115c50497']")).Click();
                    else
                    {
                        WaitUntilElementExists(By.CssSelector(".largerImage[src='https://images-blue.financial.membersuite.com/5a736d72-0004-cf25-05d0-0b403a78f8a8/32328/5a736d72-001c-c8ff-d848-9034e7b90497']")).Click();
                    }
                    System.Threading.Thread.Sleep(DelayWaitOnSelection);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnAddToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.Add_tocart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("ClickOnContinueToCart");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.continue_cart)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }

                try
                {
                    SetStepName("SelectingCheckout");
                    WaitUntilElementExists(By.CssSelector(Shop_locators.checkout_btn)).Click();
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    NUnit.Framework.Assert.IsTrue(true);
                }
                catch (Exception ex)
                {
                    TestError(ex);
                    NUnit.Framework.Assert.IsTrue(false);
                }
                SetStepName("SelectShippingAddress");
                WaitUntilElementExists(By.CssSelector("div.new-address")).Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("EnterShippingAddress");
                try
                {
                    SetStepName("EnterNewAddress");
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).SendKeys("41 Boggo Rd");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")));
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).SendKeys("Dutton Park");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")));
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).Clear();
                    WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).SendKeys("4102");
                    System.Threading.Thread.Sleep(1000);
                    ScrollIntoView(WaitUntilElementVisible(By.CssSelector("mat-select[data-test='shipping-country']")));
                    WaitUntilElementVisible(By.CssSelector("mat-select[data-test='shipping-country']")).Click();
                    System.Threading.Thread.Sleep(1000);
                    //GetElementWithText(null, By.CssSelector("span.mat-option-text"), "Australia").Click();
                    var cntry = GetElementWithText(null, By.CssSelector("span.mat-option-text"), "Australia");
                    //< span class="mat-option-text">Australia</span>
                     ScrollIntoView(cntry);
                    cntry.Click();

                    System.Threading.Thread.Sleep(DelayScreenChange);


                    var valButtons = GetElements(null, By.CssSelector("button.add-btn"));
                    if (valButtons != null)
                    {
                        foreach (var valBtn in valButtons)
                        {
                            if (valBtn.Text.Contains("Validate and Save Address"))
                                valBtn.Click();
                        }
                    }
                    System.Threading.Thread.Sleep(DelayScreenChange);
                    if (ElementExist(By.CssSelector("mat-error")))
                    {
                        NUnit.Framework.Assert.IsTrue(false, "Address verification failed");
                    }

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
                    SetStepName("ClickNext");
                    WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                }
                catch { }

                System.Threading.Thread.Sleep(DelayScreenChange);

                SetStepName("SelectOrderByShippingMethod");
                GetElementWithText(null, By.CssSelector("div.name"), "Order by Weight").Click();
                System.Threading.Thread.Sleep(DelayScreenChange);

                if (!ElementExist(By.CssSelector("div.error-title")))
                {
                    NUnit.Framework.Assert.IsTrue(false, "Order by Weight should not be valid");
                }

                SetStepName("SelectShippingMethodUnitedKingdom");
                GetElementWithText(null, By.CssSelector("div.name"), "Intl Shipping").Click();
                System.Threading.Thread.Sleep(3000);

                if (ElementExist(By.CssSelector("div.error-title")))
                {
                    NUnit.Framework.Assert.IsTrue(false, "International Shipping should be valid");
                }

                SetStepName("ClickNext");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();

                SetStepName("GoingToCheckout");
                PayLaterCheckout();
            }
            catch (Exception ex)
            {
                TestError(ex);
                NUnit.Framework.Assert.IsTrue(false);
            }
        }

    }
}
