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

//    @When("user should be able to login into users page")
//    public void user_should_be_able_to_login_into_users_page() {
//        mainPage.loginSignup.click();
//
//        WebDriver driver = WebDriverRunner.getWebDriver();
//        JavascriptExecutor js = (JavascriptExecutor)driver;
//        js.executeScript("arguments[0].click();", mainPage.loginOption);
//        BrowserUtils.wait(3);
//
//        mainPage.emailInput.sendKeys("14060159@voomail.com");
//        mainPage.passInput.sendKeys("Password1!");
//        mainPage.signinButton.click();

//
//        BrowserUtils.wait(2);
//        mainPage.allowCookies.click();
//        BrowserUtils.wait(3);
//
//    Assert.assertTrue(mainPage.homeOnMainPage.getText().equals("Home"));
//    Assert.assertTrue(mainPage.eventsOnMainPage.getText().equals("Events"));
//    Assert.assertTrue(mainPage.communityOnMainPage.getText().equals("Community"));
//    Assert.assertTrue(mainPage.shopOnMainPage.getText().equals("Shop"));
//    Assert.assertTrue(mainPage.donationsOnMainPage.getText().equals("Donations"));
//    Assert.assertTrue(mainPage.certificationsOnMainPage.getText().equals("Certifications"));
////    Assert.assertTrue(mainPage.newFormOnMainPage.getText().equals("831 new form"));
////    Assert.assertTrue(mainPage.newFormLinkOnMainPage.getText().equals("new form link"));
//    Assert.assertNotNull(mainPage.cartOnMainPage);
//    Assert.assertTrue(mainPage.welcomeOnMainPage.getText().equals("Welcome!"));
//
//
//    mainPage.profileButton.click();
//    BrowserUtils.wait(1);
//    mainPage.loginOnProfile.click();
//    BrowserUtils.wait(3);
//    mainPage.usernameInput.sendKeys(ConfigurationReader.getProperty("username"));
//    BrowserUtils.wait(1);
//    mainPage.passwordInput.sendKeys(ConfigurationReader.getProperty("password"));
//    BrowserUtils.wait(1);
//    mainPage.signInButton.click();
//    BrowserUtils.wait(12);
//    mainPage.tuesdayCooper.click();
//    BrowserUtils.wait(3);
//    }

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
    public void user_should_be_able_to_fill_out_address_and_payment_for_fund() {
    donationPage.fivedollarDonation.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
//    BrowserUtils.wait(2);
    donationPage.streetOne.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("address1"));
//    BrowserUtils.wait(1);
    donationPage.streetTwo.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("address2"));
//    BrowserUtils.wait(2);
    donationPage.city.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("city"));
//    BrowserUtils.wait(2);
    donationPage.state.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
//    BrowserUtils.wait(2);
    BrowserUtils.clickWithJS(donationPage.georgiaState);
//    BrowserUtils.wait(2);
    donationPage.zipCode.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("zipcode"));
//    BrowserUtils.wait(2);
    donationPage.creditCard.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("creditCardVisa"));
//    BrowserUtils.wait(2);
    donationPage.nameOnCreditCard.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("nameOnCard"));
//    BrowserUtils.wait(2);
    donationPage.expMonth.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
//    BrowserUtils.wait(1);
    BrowserUtils.clickWithJS(donationPage.mayExpireMonth);
//    BrowserUtils.wait(2);
    donationPage.expYear.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    BrowserUtils.wait(1);
    BrowserUtils.clickWithJS(donationPage.tweentysixExpireYear);
//    BrowserUtils.wait(2);
    donationPage.securityCode.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("SecurityCode"));
//    BrowserUtils.wait(2);
    donationPage.continueOnDonation.shouldBe(Condition.visible, Duration.ofSeconds(10)).click();
//    BrowserUtils.wait(2);
    donationPage.processDonation.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
//    BrowserUtils.wait(22);



    }

    @Then("user should be able to get successful donation message")
    public void user_should_be_able_to_get_successful_donation_message() {

    //    Assert.assertTrue(donationPage.donationSuccessful.getText().equals("Donation Successful"));
    //    Assert.assertTrue(donationPage.thankYouMessage.getText().equals("Thank you for donating to the funny money fund."));
        BrowserUtils.wait(3);
        donationPage.closeButtonOnDonation.shouldBe(Condition.visible,Duration.ofSeconds(20)).click();
        BrowserUtils.wait(2);
    }





}
