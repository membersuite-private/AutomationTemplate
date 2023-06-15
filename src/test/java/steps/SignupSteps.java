package steps;


import com.codeborne.selenide.Condition;
import com.codeborne.selenide.SelenideElement;
import com.codeborne.selenide.WebDriverRunner;
import io.cucumber.java.en.Then;
import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;
import pages.MainPage;
import io.cucumber.java.en.And;
import pages.SignupPage;
import utils.BrowserUtils;
import utils.ConfigurationReader;
import java.text.SimpleDateFormat;
import java.time.Duration;
import java.util.Arrays;
import java.util.Date;

import static com.codeborne.selenide.Selenide.*;

public class SignupSteps {

    MainPage mainPage = new MainPage();
    SignupPage signupPage = new SignupPage();
    String firstname;
    String lastname;
    String dateMail;
    private String age;

    @And("^click on Login/Signup$")
    public void clickLoginSignup() {
        mainPage.loginSignup.click();
//        BrowserUtils.wait(1);
    }


    @And("click on Join")
    public void clickOnJoin() {

        WebDriver driver = WebDriverRunner.getWebDriver();
        JavascriptExecutor js = (JavascriptExecutor)driver;
        js.executeScript("arguments[0].click();", mainPage.joinOption);
        BrowserUtils.wait(3);
    }

    @And("type {string} on First Name field")
    public void typeOnFirstNameField(String firstName) {
        firstname = firstName;
        signupPage.firstNameField.sendKeys(firstName);
        Assert.assertEquals("firstName", signupPage.firstNameField.attr("formcontrolname"));
    }

    @And("type {string} on Last Name field")
    public void typeOnLastNameField(String lastName) {
        lastname=lastName;
        signupPage.lastNameField.sendKeys(lastName);
    }

    @And("type mail")
    public void typeMail() {
        SimpleDateFormat dtf = new SimpleDateFormat("ddMMhhmm");
        String date = dtf.format(new Date());
        ConfigurationReader.setProperty("date",date);
        dateMail = ConfigurationReader.getProperty("date")+"@yopmail.com";
        signupPage.emailField.sendKeys(dateMail);
    }

    @And("type {string} Password")
    public void typePassword(String password) {
        signupPage.passwordField.sendKeys(password);
    }

    @And("click Signup")
    public void clickSignup() {
        signupPage.signUpButton.click();
//        BrowserUtils.wait(5);
    }

    @Then("Create account page appear")
    public void createAccountPageAppear() {
        signupPage.createAccountTitle.shouldBe(Condition.visible,Duration.ofSeconds(10));
//        signupPage.step1from3.shouldBe(Condition.visible);
        Assert.assertEquals(firstname, signupPage.firstnameAppear.attr("ng-reflect-model"));
        Assert.assertEquals(lastname, signupPage.lastnameAppear.attr("ng-reflect-model"));


    }

    @And("user select Individual Type {int} on type selection")
    public void userSelectInvidualTypeOnTypeSelection(int arg0) {
        WebDriver driver = WebDriverRunner.getWebDriver();
        JavascriptExecutor js = (JavascriptExecutor)driver;
        js.executeScript("arguments[0].click();", signupPage.typeSelector);
        //        signupPage.typeSelector.click();
        signupPage.typeIndividualType3.click();

    }


    @And("user select Home Address")
    public void userSelectHomeAddressOnAdresses() {
        WebDriver driver = WebDriverRunner.getWebDriver();
        JavascriptExecutor js = (JavascriptExecutor)driver;
        js.executeScript("arguments[0].click();", signupPage.homeAddressRadio);

        String addres1 = ConfigurationReader.getProperty("address1");
        String city = ConfigurationReader.getProperty("city");
        String zipcode = ConfigurationReader.getProperty("zipcode");

        signupPage.address1Input.sendKeys(addres1);
        signupPage.cityInput.sendKeys(city);
        signupPage.zipCodeInput.sendKeys(zipcode);

        JavascriptExecutor js2 = (JavascriptExecutor)driver;
        js2.executeScript("arguments[0].click();", signupPage.countrySelect);
        signupPage.USAoption.click();



    }

    @And("user type {string} on age field")
    public void userTypeOnAgeField(String arg0) {
    }

    @And("user select Phone home on Phone Numbers and type {string}")
    public void userSelectPhoneHomeOnPhoneNumbersAndType(String phone) {
        WebDriver driver = WebDriverRunner.getWebDriver();
        JavascriptExecutor js = (JavascriptExecutor)driver;
        js.executeScript("arguments[0].click();", signupPage.phoneNumberRadio);
//        signupPage.phoneNumberRadio.selectRadio("phone-number-MomsPhone-input");
        signupPage.phoneNumberText.sendKeys(phone);
    }

    @And("click on Next")
    public void clickOnNext() {
        signupPage.nextButton.shouldBe(Condition.visible, Duration.ofSeconds(10));
        WebDriver driver = WebDriverRunner.getWebDriver();
        JavascriptExecutor js = (JavascriptExecutor)driver;
        js.executeScript("arguments[0].click();", signupPage.nextButton);
//        signupPage.nextButton.click();
        BrowserUtils.wait(5);
    }

    @Then("Organization Information appear")
    public void organizationInformationAppear() {
        signupPage.organizationInformationTitle.shouldBe(Condition.visible,Duration.ofSeconds(10));
//        signupPage.step2from3.shouldBe(Condition.visible);
//        Assert.assertEquals(firstname, signupPage.firstnameAppear.attr("ng-reflect-model"));
//        Assert.assertEquals(lastname, signupPage.lastnameAppear.attr("ng-reflect-model"));

    }

    @And("user type {string} on affiliated name")
    public void userTypeOnAffiliatedName(String arg0) {
        signupPage.inputSelectOrg.sendKeys(arg0);
    }

    @And("choose {string} on organization role")
    public void chooseOnOrganizationRole(String arg0) {
        WebDriver driver = WebDriverRunner.getWebDriver();
        JavascriptExecutor js = (JavascriptExecutor)driver;
        js.executeScript("arguments[0].click();", signupPage.selectOrgRole);
        $(By.xpath("//td[.=' 102 org ']")).click();
        BrowserUtils.wait(5);
        js.executeScript("arguments[0].click();", signupPage.selectOrgRole);
        signupPage.memberContactOption.click();
        BrowserUtils.wait(5);
    }

    @Then("a confirmation screen appear")
    public void aConfirmationScreenAppear() {
        signupPage.thankYouMessage.shouldBe(Condition.visible,Duration.ofSeconds(10));
        Assert.assertTrue(signupPage.confirmationMessage.getText().contains(dateMail));
        signupPage.purchaseIndividualMembership.shouldBe(Condition.visible);
        signupPage.purchaseOrganizationMembership.shouldBe(Condition.visible);
        BrowserUtils.wait(3);
        signupPage.returnToHomeButton.click();
    }

    @Then("Communication Preferences appear")
    public void communicationPreferencesAppear() {
        signupPage.comunicationPreferencesTitle.shouldBe(Condition.visible,Duration.ofSeconds(10));
        signupPage.emailComunication.shouldBe(Condition.visible);
        signupPage.mailComunication.shouldBe(Condition.visible);
        signupPage.faxComunication.shouldBe(Condition.visible);
    }

    @Then("First Name is required. message appear")
    public void firstNameIsRequiredMessageAppear() {
        signupPage.errorFirstNameMessage.shouldBe(Condition.visible,Duration.ofSeconds(10));
    }

    @Then("Last Name is required. message appear")
    public void lastNameIsRequiredMessageAppear() {
        signupPage.errorLastNameMessage.shouldBe(Condition.visible,Duration.ofSeconds(10));
    }

    @And("user type {string} on Age field")
    public void userInputAge(String arg0){
        signupPage.ageInput.sendKeys(arg0);
    }

    @And("don't type mail")
    public void donTTypeMail() {
        signupPage.emailField.sendKeys("");
    }

    @Then("Email is required. message appear")
    public void emailIsRequiredMessageAppear() {
        signupPage.errorEmailMessage.shouldBe(Condition.visible);
        Assert.assertEquals("sign-up-button-disabled",signupPage.signUpButton.getAttribute("ng-reflect-ng-class"));
    }
}