using MRPTests.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace MRPTests.Helper
{
    public class MrpTestBase : TestBase
    {
        public string CreditCardNumber
        {
            get { return config.RunEnvironment.ToLower() == "prod" ? config.ProdCreditCardNumber : config.RunEnvironment.ToLower() == "green" ? config.GreenCreditCardNumber : config.BlueCreditCardNumber; }
        }

        public string NameOnCard
        {
            get { return config.RunEnvironment.ToLower() == "prod" ? config.ProdNameOnCard : config.RunEnvironment.ToLower() == "green" ? config.GreenNameOnCard : config.BlueNameOnCard; }
        }

        public string SecCode
        {
            get { return config.RunEnvironment.ToLower() == "prod" ? config.ProdSecCode : config.RunEnvironment.ToLower() == "green" ? config.GreenSecCode : config.BlueSecCode; }
        }

        public string ExpMonth
        {
            get { return config.RunEnvironment.ToLower() == "prod" ? config.ProdExpMonth : config.RunEnvironment.ToLower() == "green" ? config.GreenExpMonth : config.BlueExpMonth; }
        }

        public string ExpYear
        {
            get { return config.RunEnvironment.ToLower() == "prod" ? config.ProdExpYear : config.RunEnvironment.ToLower() == "green" ? config.GreenExpYear : config.BlueExpYear; }
        }

        public void SelectDropDownItem(string stepName, string inputCssSelector, string valueCssSelector, string value)
        {
            SetStepName(stepName);
            WaitUntilElementVisible(By.CssSelector(inputCssSelector)).Click();
            Thread.Sleep(1000);
            var valElement = GetElementWithText(null, By.CssSelector(valueCssSelector), value);
            valElement.Click();
        }

        public void SelectMenuItem(string stepName, string menuItemText, string subMenuItemText = "")
        {
            SetStepName(stepName);
            var e2 = WaitUntilElementVisible(By.XPath("//nav-items//span[contains(text(),'" + menuItemText + "')]"));
            ScrollIntoView(e2);
            e2.Click();
            System.Threading.Thread.Sleep(1000);

            if (string.IsNullOrEmpty(subMenuItemText) == false)
            {
                var menuOption = WaitUntilElementVisible(By.CssSelector("app-nav-modal div.nav-modal-links-contain"));
                if (menuOption != null)
                {
                    var mo = GetElementWithText(menuOption, By.CssSelector("div.nav-modal-link"), subMenuItemText);
                    if (mo != null)
                        mo.Click();
                }
            }
        }

        public void EnterKeys(string textToEnter, string inputCssSelector, string stepName = "")
        {
            if (string.IsNullOrEmpty(stepName) == false)
                SetStepName(stepName);
            var inputElement = WaitUntilElementVisible(By.CssSelector(inputCssSelector));
            ScrollIntoView(inputElement);
            inputElement.Clear();
            inputElement.SendKeys(textToEnter);
        }

        public void EnterKeys(string textToEnter, string promptText, string promptCssSelector, string inputCssSelector, string stepName = "")
        {
            if (string.IsNullOrEmpty(stepName) == false)
                SetStepName(stepName);
            var ageInput = GetElement(GetParentElement(GetElementWithText(null, By.CssSelector(promptCssSelector), promptText)), 
                By.CssSelector(inputCssSelector));
            ScrollIntoView(ageInput);
            ageInput.Clear();
            ageInput.SendKeys(textToEnter);
        }

        public void ButtonClick(string buttonLabel, string buttonCssSelector = "button", int delayMS = 1000, string stepName = "", int buttonNumber = 0)
        {
            if (string.IsNullOrEmpty(buttonCssSelector) == true)
                buttonCssSelector = "button";

            WaitUntilElementExists(By.CssSelector( buttonCssSelector));
            var btns = GetElementsWithText(null, By.CssSelector(buttonCssSelector), buttonLabel);
            if ((buttonNumber <= 1) && (btns.Count == 1))
            {
                var btn = btns.First();
                ScrollIntoView(btn);
                btn.Click();
            }
            else if ((buttonNumber > 0) && (btns.Count >= buttonNumber))
            {
                var btn = btns.Skip(buttonNumber-1).First();
                ScrollIntoView(btn);
                btn.Click();
            }
            System.Threading.Thread.Sleep(delayMS);
        }

        private void ScrollToAndClickOnText(string txt, string cssSelector, int delayMS = 1000, string stepName = "")
        {
            WaitUntilElementExists(By.CssSelector(cssSelector));
            int ctr = 0;
            IWebElement item = null;
            do
            {
                item = GetElementWithText(null, By.CssSelector(cssSelector), txt);
                if (item == null)
                {
                    ScrollView(400);
                    Thread.Sleep(DelayWaitOnSelection);
                }
                ctr++;
            } while ((item == null) && (ctr < 7));

            if (item != null)
            {
                ScrollIntoView(item);
                item.Click();
                System.Threading.Thread.Sleep(delayMS);
            }
        }

        public void SelectProfileMenuOption(string menuText)
        {
            WaitUntilElementExists(By.XPath("//menu[@class='dropdown expanded']//a[contains(text(),'" + menuText + "')]")).Click();
            Thread.Sleep(1000);
        }

        public void PayLaterCheckout()
        {
            SetStepName("SelectPayLater");
            WaitUntilElementExists(By.CssSelector("mat-radio-button.pay-later div.mat-radio-container")).Click();
            System.Threading.Thread.Sleep(1000);

            SetStepName("Address");
            if (ElementExist(By.XPath(membership_locator.radio_address_select)))
            {
                var addr = WaitUntilElementExists(By.XPath(membership_locator.radio_address_select));
                if (addr != null)
                {
                    ScrollIntoView(addr);
                    addr.Click();
                }
            }
            else if (ElementExist(By.CssSelector("mat-radio-button[data-test='shipping-address-new']")))
            {
                SetStepName("SelectNewAddress");
                var addrNewBtn = WaitUntilElementVisible(By.CssSelector("mat-radio-button[data-test='shipping-address-new']"));
                ScrollIntoView(addrNewBtn);
                addrNewBtn.Click();
                System.Threading.Thread.Sleep(1000);

                var btn2 = GetElements(addrNewBtn, By.CssSelector("div.mat-radio-container"));
                if ((btn2 != null) && (btn2.Count > 0))
                {
                    btn2.First().Click();
                    System.Threading.Thread.Sleep(1000);

                    //try
                    //{
                        SetStepName("EnterNewAddress");
                        WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).Clear();
                        WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-address-1']")).SendKeys("601 S WASHINGTON ST");
                        System.Threading.Thread.Sleep(1000);
                        ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")));
                        WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).Clear();
                        WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-city']")).SendKeys("STILLWATER");
                        System.Threading.Thread.Sleep(1000);
                        ScrollIntoView(WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")));
                        WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).Clear();
                        WaitUntilElementVisible(By.CssSelector("input[data-test='shipping-zip-code']")).SendKeys("74074");
                        System.Threading.Thread.Sleep(1000);
                        ScrollIntoView(WaitUntilElementVisible(By.CssSelector("mat-select[data-test='input-address-state']")));
                        WaitUntilElementVisible(By.CssSelector("mat-select[data-test='input-address-state']")).Click();
                        System.Threading.Thread.Sleep(1000);
                        WaitUntilElementVisible(By.CssSelector("mat-option[ng-reflect-value='US']")).Click();

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
                            Assert.IsTrue(false, "Address verification failed");
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

                        var updateBtn = WaitUntilElementVisible(By.CssSelector("button[data-test='update-button']"));
                        ScrollIntoView(updateBtn);
                        updateBtn.Click();
                }
            }
            else
            {
                var addr = WaitUntilElementExists(By.XPath(membership_locator.radio_address_select));
                if (addr != null)
                {
                    ScrollIntoView(addr);
                    addr.Click();
                }
            }
            System.Threading.Thread.Sleep(1000);

            SetStepName("FinalizeCheckout");
            GetElementWithText(null, By.CssSelector("button.button-blue"), "Checkout").Click();
            System.Threading.Thread.Sleep(3000);
            driver.SwitchTo().ActiveElement();

            WaitUntilElementVisible(By.CssSelector("div.cdk-overlay-backdrop"));
            SetStepName("CheckingTypeOfMsg");

            if (ElementExist(By.CssSelector("span.checkout")))
            {
                var spanCheckout = WaitUntilElementVisible(By.CssSelector("span.checkout"));
                if (spanCheckout != null)
                {
                    SetStepName("LookingForYouAreCheckingOut");
                    if (spanCheckout.Text.Contains("You are checking out"))
                    {
                        WaitUntilElementVisible(By.CssSelector("button.left-confirmation-button")).Click();
                        Thread.Sleep(5000);
                    }
                }
            }

            var checkout = WaitUntilElementVisible(By.CssSelector("div.message"));
            if (checkout != null)
            {
                SetStepName("LookingForOrderSuccessful");
                if ((checkout.Text.Contains("Order Successful")) ||
                    (checkout.Text.Contains("confirmation email has been sent")))
                {
                    WaitUntilElementVisible(By.CssSelector("modal-payment-message button.button-blue")).Click();
                    Assert.IsTrue(true);
                }
                else if (GetElementWithText(null, By.CssSelector("button.button-blue"),"Go Home") != null)
                {
                    GetElementWithText(null, By.CssSelector("button.button-blue"), "Go Home").Click();
                    Thread.Sleep(5000);
                    Assert.IsTrue(true);
                }
                else
                    Assert.IsTrue(false);
            }
        }
    }
}
