package pages;

import com.codeborne.selenide.SelenideElement;
import org.openqa.selenium.By;

import static com.codeborne.selenide.Selenide.$;

public class SignupPage {
    public SelenideElement firstNameField = $(By.xpath("//input[@formcontrolname='firstName']"));
    public SelenideElement lastNameField = $(By.xpath("//input[@formcontrolname='lastName']"));
    public SelenideElement emailField = $(By.xpath("//input[@formcontrolname='email']"));
    public SelenideElement passwordField = $(By.xpath("//input[@formcontrolname='password']"));
    public SelenideElement signUpButton = $(By.xpath("//button[@data-test-id='sign-up-button']"));
    public SelenideElement createAccountTitle = $(By.xpath("//h3[.='Create Account']"));
    public SelenideElement organizationInformationTitle = $(By.xpath("//h3[.=' Organization Information ']"));
    public SelenideElement comunicationPreferencesTitle = $(By.xpath("//span[.='General Communication Options']"));
    public SelenideElement emailComunication = $(By.xpath("//span[.='Email?']"));
    public SelenideElement mailComunication = $(By.xpath("//span[.='Mail?']"));
    public SelenideElement faxComunication = $(By.xpath("//span[.='Fax?']"));
    public SelenideElement step1from3 = $(By.xpath("//h2[.=' (1/3) ']"));
    public SelenideElement step2from3 = $(By.xpath("//h2[.=' (2/3) ']"));
    public SelenideElement firstnameAppear = $(By.xpath("//input[@ng-reflect-name='firstName']"));
    public SelenideElement lastnameAppear = $(By.xpath("//input[@ng-reflect-name='lastName']"));
    public SelenideElement typeSelector = $(By.xpath("//div[@class= 'mat-select-value ng-tns-c158-4']"));
    public SelenideElement typeIndividualType3 = $(By.xpath("//span[.= 'Individual type 3']"));
    public SelenideElement phoneNumberRadio = $(By.id("phone-number-MomsPhone-input"));
    public SelenideElement phoneNumberText = $(By.id("phone"));
    public SelenideElement homeAddressRadio = $(By.xpath("(//*[@type='radio'])[5]"));
    public SelenideElement address1Input = $(By.xpath("//*[@placeholder='Address 1']"));
    public SelenideElement cityInput = $(By.xpath("//*[@placeholder='City']"));
    public SelenideElement zipCodeInput = $(By.xpath("//*[@placeholder='Zip Code']"));
    public SelenideElement countrySelect = $(By.xpath("(//*[.='Country'])[1]"));
    public SelenideElement USAoption = $(By.xpath("//*[@ng-reflect-value='US']"));
    public SelenideElement nextButton = $(By.xpath("//button[.=' Next ']"));
    public SelenideElement inputSelectOrg = $(By.xpath("//*[@data-test='input-selected-org']"));
    public SelenideElement selectOrgRole = $(By.xpath("//*[@name='orgRole']"));
    public SelenideElement memberContactOption = $(By.xpath("//span[.=' Member Contact']"));
    public SelenideElement thankYouMessage = $(By.xpath("//h3[.='Thank You!']"));
    public SelenideElement confirmationMessage = $(By.xpath("//*[@class='info-text']"));
    public SelenideElement purchaseIndividualMembership = $(By.xpath("//*[.='Individual Membership']"));
    public SelenideElement purchaseOrganizationMembership = $(By.xpath("//*[.='Organization Membership']"));
    public SelenideElement returnToHomeButton = $(By.xpath("//button[.=' Return to Home ']"));
    public SelenideElement errorFirstNameMessage = $(By.xpath("//label[.=' cancel  First Name is required. ']"));
    public SelenideElement errorLastNameMessage = $(By.xpath("//label[.=' cancel  Last Name is required. ']"));
    public SelenideElement errorEmailMessage = $(By.xpath("//label[.=' cancel  Email is required. ']"));
    public SelenideElement ageInput = $(By.xpath("//input[@ng-reflect-name='Age']"));


//    public SelenideElement getErrorField(String message){
//        SelenideElement errorMessageElement = $(By.xpath("(//label[.="+message+"])[1]"));
//        return errorMessageElement;
//    }

}

