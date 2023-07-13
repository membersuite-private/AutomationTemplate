package steps;

import com.codeborne.selenide.Condition;
import com.codeborne.selenide.WebDriverRunner;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;
import pages.DonationPage;
import pages.LoginPage;
import pages.MainPage;
import utils.BrowserUtils;
import utils.ConfigurationReader;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import io.cucumber.java.eo.Do;
import org.junit.Assert;

import java.time.Duration;

public class DonationStepDefs {

    MainPage mainPage= new MainPage();
    DonationPage donationPage= new DonationPage();

    @Then("user should be able to click make donation")
    public void user_should_be_able_to_click_make_donation() {
        donationPage.donationsOnMain.click();
        BrowserUtils.wait(1);
        BrowserUtils.clickWithJS(donationPage.makeDonation);
        BrowserUtils.wait(2);
    }

    @Then("user should be able to choose donation fund")
    public void user_should_be_able_to_choose_donation_fund() {
        BrowserUtils.clickWithJS(donationPage.funnyMoneyFundExample);
        BrowserUtils.wait(1);
    }

    @Then("user should be able to fill out address and payment for fund")
    public void user_should_be_able_to_fill_out_address_and_payment_for_fund()
    {
        donationPage.fivedollarDonation.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        donationPage.streetOne.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("address1"));
        donationPage.streetTwo.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("address2"));
        donationPage.city.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("city"));
        donationPage.state.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        BrowserUtils.clickWithJS(donationPage.georgiaState);
        donationPage.zipCode.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("zipcode"));
        donationPage.creditCard.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("creditCardVisa"));
        donationPage.nameOnCreditCard.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("nameOnCard"));
        donationPage.expMonth.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        BrowserUtils.clickWithJS(donationPage.mayExpireMonth);
        donationPage.expYear.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        BrowserUtils.wait(1);
        BrowserUtils.clickWithJS(donationPage.tweentysixExpireYear);
        donationPage.securityCode.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("SecurityCode"));
        donationPage.continueOnDonation.shouldBe(Condition.visible, Duration.ofSeconds(10)).click();
        donationPage.processDonation.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    }

    @Then("user should be able to get successful donation message")
    public void user_should_be_able_to_get_successful_donation_message() {
        donationPage.closeButtonOnDonation.shouldBe(Condition.visible,Duration.ofSeconds(20)).click();
    }





}
