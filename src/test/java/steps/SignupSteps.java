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

    }


    @And("click on Join")
    public void clickOnJoin() {
        BrowserUtils.clickWithJS(mainPage.joinOption);
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
        System.out.println(dateMail);
        signupPage.emailField.sendKeys(dateMail);
    }

    @And("type {string} Password")
    public void typePassword(String password) {
        signupPage.passwordField.sendKeys(password);
    }

    @And("click Signup")
    public void clickSignup() {
        signupPage.signUpButton.click();

    }

    @Then("Create account page appear")
    public void createAccountPageAppear() {
        signupPage.createAccountTitle.shouldBe(Condition.visible,Duration.ofSeconds(10));
        Assert.assertEquals(firstname, signupPage.firstnameAppear.attr("ng-reflect-model"));
        Assert.assertEquals(lastname, signupPage.lastnameAppear.attr("ng-reflect-model"));


    }

    @And("user select Individual Type {int} on type selection")
    public void userSelectInvidualTypeOnTypeSelection(int arg0) {
        BrowserUtils.clickWithJS(signupPage.typeSelector);
        signupPage.typeIndividualType3.click();

    }


    @And("user select Home Address")
    public void userSelectHomeAddressOnAdresses() {
        String addres1 = ConfigurationReader.getProperty("address1");
        String city = ConfigurationReader.getProperty("city");
        String zipcode = ConfigurationReader.getProperty("zipcode");

        signupPage.address1Input.shouldBe(Condition.visible,Duration.ofSeconds(5)).sendKeys(addres1);
        signupPage.cityInput.shouldBe(Condition.visible,Duration.ofSeconds(5)).sendKeys(city);
        signupPage.zipCodeInput.shouldBe(Condition.visible,Duration.ofSeconds(5)).sendKeys(zipcode);

        signupPage.countrySelect.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        signupPage.USAoption.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();

    }

    @And("user type {string} on age field")
    public void userTypeOnAgeField(String arg0) {
    }

    @And("user select Phone home on Phone Numbers and type {string}")
    public void userSelectPhoneHomeOnPhoneNumbersAndType(String phone) {
        BrowserUtils.clickWithJS(signupPage.phoneNumberRadio);
        signupPage.phoneNumberText.sendKeys(phone);
    }

    @And("click on Next")
    public void clickOnNext() {
        signupPage.nextButton.shouldBe(Condition.visible, Duration.ofSeconds(10));
        BrowserUtils.clickWithJS(signupPage.nextButton);
        BrowserUtils.wait(2);
    }

    @Then("Organization Information appear")
    public void organizationInformationAppear() {
        signupPage.organizationInformationTitle.shouldBe(Condition.visible,Duration.ofSeconds(10));

    }

    @And("user type {string} on affiliated name")
    public void userTypeOnAffiliatedName(String arg0) {
        signupPage.inputSelectOrg.sendKeys(arg0);
    }

    @And("choose {string} on organization role")
    public void chooseOnOrganizationRole(String arg0) {

        BrowserUtils.clickWithJS(signupPage.selectOrgRole);
        $(By.xpath("//td[.=' Purple Organization ']")).click();
        BrowserUtils.wait(5);
        BrowserUtils.clickWithJS(signupPage.selectOrgRole);
        signupPage.memberContactOption.click();
        BrowserUtils.wait(5);
    }

    @Then("a confirmation screen appear")
    public void aConfirmationScreenAppear() {
        signupPage.thankYouMessage.shouldBe(Condition.visible,Duration.ofSeconds(10));
        Assert.assertTrue(signupPage.confirmationMessage.getText().contains(dateMail));
        signupPage.purchaseIndividualMembership.shouldBe(Condition.visible);
        signupPage.purchaseOrganizationMembership.shouldBe(Condition.visible);
        BrowserUtils.wait(1);
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
        if (signupPage.ageInput.exists()){
            signupPage.ageInput.sendKeys(arg0);
        }
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

    @Then("user should be able to login with same email and password")
    public void userShouldBeAbleToLoginWithSameEmailAndPassword() {
        mainPage.loginSignup.click();
        BrowserUtils.clickWithJS(mainPage.loginOption);
        BrowserUtils.wait(3);

        mainPage.emailInput.sendKeys(dateMail);
        mainPage.passInput.sendKeys("Password1!");
        BrowserUtils.clickWithJS(mainPage.signInButton);
    }

    @And("user select not affiliated with an Organization")
    public void userSelectNotAffiliatedWithAnOrganization() {
        signupPage.radioNotAffiliated.click();
    }

    @Then("a confirmation screen appear without Organization Membership")
    public void aConfirmationScreenAppearWithoutOrganizationMembership() {
        signupPage.thankYouMessage.shouldBe(Condition.visible,Duration.ofSeconds(10));
        Assert.assertTrue(signupPage.confirmationMessage.getText().contains(dateMail));
        signupPage.purchaseIndividualMembership.shouldBe(Condition.visible);
        BrowserUtils.wait(1);
        signupPage.returnToHomeButton.click();
    }
}