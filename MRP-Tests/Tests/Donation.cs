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
using System.Threading;

namespace MRPTests.Tests
{
    public class Donation : MrpTestBase
    {
        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void MakeADonation(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_Page(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                SelectMenuItem("SelectDonationsMakeADonation", "Donations", "Make a Donation");
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectFirstDonationOption");
                WaitUntilElementVisible(By.CssSelector("div.donation-body"));
                var btns = GetElements(null, By.CssSelector("div.donation-body"), By.CssSelector("div.fund-donation"), By.CssSelector("mat-radio-button"));
                if ((btns != null) && (btns.Count > 0))
                {
                    var btn = btns.First();
                    ScrollIntoView(btn);
                    btn.Click();
                    Thread.Sleep(DelayScreenChange);
                }

                if (IsProduction)
                    EnterKeys(".01", "input[name='donationValue']", "EnterDonationAmount");
                else
                    EnterKeys("1.00", "input[name='donationValue']", "EnterDonationAmount");
                EnterKeys(s_k_values.address, "input[data-test='shipping-address-1']", "EnterStreetAddress");
                EnterKeys(s_k_values.city, "input[data-test='shipping-city']", "EnterCity");
                EnterKeys(s_k_values.zipcode, "input[data-test='shipping-zip-code']", "EnterZip");

                SelectDropDownItem("SelectState", "mat-select[data-test='shipping-state']", "span.mat-option-text", "Oklahoma");

                SelectDropDownItem("SelectCountry", "mat-select[data-test='input-address-state']", "span.mat-option-text", "United States");

                EnterKeys(CreditCardNumber, "input[data-test='input-card-number']", "EnterCreditCardNumber");
                EnterKeys(NameOnCard, "input[data-test='input-holder-name']", "EnterNameOnCard");
                EnterKeys(SecCode, "input[data-test='input-sec-code']", "EnterSEC");
                SelectDropDownItem("SelectExpMonth", "mat-select[data-test='input-exp-month']", "span.mat-option-text", ExpMonth);
                SelectDropDownItem("SelectExpYear", "mat-select[data-test='input-exp-year']", "span.mat-option-text", ExpYear);

                SetStepName("SelectContinue");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectProcessDonation");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                Thread.Sleep(DelayScreenChange);

                var msgTitle = WaitUntilElementVisible(By.CssSelector("modal-message div.title"));
                SetStepName("FinalMessage");
                if (msgTitle.Text.Contains("Failed"))
                    Assert.IsTrue(false);
                else
                    Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void OrgMakeADonation(String Correct)
        {
            try
            {
                Login login = new Login();
                login.Login_OrgPage(Correct);
                TestId = login.TestId;
                Thread.Sleep(DelayScreenChange);

                SelectMenuItem("SelectDonationsMakeADonation", "Donations", "Make a Donation");
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectFirstDonationOption");
                WaitUntilElementVisible(By.CssSelector("div.donation-body"));
                var btns = GetElements(null, By.CssSelector("div.donation-body"), By.CssSelector("div.fund-donation"), By.CssSelector("mat-radio-button"));
                if ((btns != null) && (btns.Count > 0))
                {
                    var btn = btns.First();
                    ScrollIntoView(btn);
                    btn.Click();
                    Thread.Sleep(DelayScreenChange);
                }

                if (IsProduction)
                    EnterKeys(".01", "input[name='donationValue']", "EnterDonationAmount");
                else
                    EnterKeys("1.00", "input[name='donationValue']", "EnterDonationAmount");
                EnterKeys(s_k_values.address, "input[data-test='shipping-address-1']", "EnterStreetAddress");
                EnterKeys(s_k_values.city, "input[data-test='shipping-city']", "EnterCity");
                EnterKeys(s_k_values.zipcode, "input[data-test='shipping-zip-code']", "EnterZip");

                SelectDropDownItem("SelectState", "mat-select[data-test='shipping-state']", "span.mat-option-text", "Oklahoma");

                SelectDropDownItem("SelectCountry", "mat-select[data-test='input-address-state']", "span.mat-option-text", "United States");

                EnterKeys(CreditCardNumber, "input[data-test='input-card-number']", "EnterCreditCardNumber");
                EnterKeys(NameOnCard, "input[data-test='input-holder-name']", "EnterNameOnCard");
                EnterKeys(SecCode, "input[data-test='input-sec-code']", "EnterSEC");
                SelectDropDownItem("SelectExpMonth", "mat-select[data-test='input-exp-month']", "span.mat-option-text", ExpMonth);
                SelectDropDownItem("SelectExpYear", "mat-select[data-test='input-exp-year']", "span.mat-option-text", ExpYear);

                SetStepName("SelectContinue");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                Thread.Sleep(DelayScreenChange);

                SetStepName("SelectProcessDonation");
                WaitUntilElementVisible(By.CssSelector("button.button-blue")).Click();
                Thread.Sleep(DelayScreenChange);

                var msgTitle = WaitUntilElementVisible(By.CssSelector("modal-message div.title"));
                SetStepName("FinalMessage");
                if (msgTitle.Text.Contains("Failed"))
                    Assert.IsTrue(false);
                else
                    Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                TestError(ex);
                Assert.IsTrue(false);
            }
        }
    }
}
