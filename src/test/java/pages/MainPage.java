package pages;


import com.codeborne.selenide.SelenideElement;
import org.openqa.selenium.By;

import static com.codeborne.selenide.Selenide.$;

public class MainPage{


    public SelenideElement allowCookies = $(By.xpath("//a[contains(text(),'Allow')]"));
    public SelenideElement profileButton = $(By.xpath("(//img[@data-test='profile-icon'])[2]"));
    public SelenideElement loginOnProfile = $(By.xpath("(//*[contains(text(),' Login')])[2]"));
    public SelenideElement usernameInput = $(By.xpath("fca60cdf-f709-4cf5-923a-8ee5ef9f9987"));
    public SelenideElement passwordInput = $(By.xpath("3d20b1e6-cdb1-44f9-8344-5533735084c7"));
    public SelenideElement signInButton = $(By.xpath("3c8f8aec-1300-49f4-8a81-eb7849b6df12"));
    public SelenideElement tuesdayCooper = $(By.xpath("//div[@class='profile-body ng-star-inserted']//div[@class='active ng-star-inserted']"));
    public SelenideElement homeOnMainPage = $(By.xpath("//*[contains(text(),'Home')]"));
    public SelenideElement eventsOnMainPage = $(By.xpath("//span[.='Events ']"));
    public SelenideElement communityOnMainPage = $(By.xpath("//span[normalize-space()='Community']"));
    public SelenideElement shopOnMainPage = $(By.xpath("//span[normalize-space()='Shop']"));
    public SelenideElement donationsOnMainPage = $(By.xpath("//span[normalize-space()='Donations']"));
    public SelenideElement certificationsOnMainPage = $(By.xpath("//span[normalize-space()='Certifications']"));
    public SelenideElement newFormOnMainPage = $(By.xpath("//span[normalize-space()='831 new form']"));
    public SelenideElement newFormLinkOnMainPage = $(By.xpath("//span[normalize-space()='new form link']"));
    public SelenideElement cartOnMainPage = $(By.xpath("//nav-cart[@class='cart-icon']//span[@class='icon-cart']"));
    public SelenideElement logoOnMainPage = $(By.xpath("//img[@class='logo-2']"));
    public SelenideElement welcomeOnMainPage = $(By.xpath("//h1[normalize-space()='Welcome!']"));
    public SelenideElement loginSignup = $(By.xpath("//span[.=' Login/SignUp ']"));
    public SelenideElement joinOption = $(By.xpath("//li//a[.=' Join ']"));
    public SelenideElement loginOption = $(By.xpath("//li//a[.=' Login ']"));
    public SelenideElement emailInput = $(By.xpath("(//input)[1]"));
    public SelenideElement passInput = $(By.xpath("(//input)[2]"));
    public SelenideElement signinButton = $(By.xpath("//button[@type='submit']"));
    public SelenideElement chooseOrg = $(By.xpath("(//div//img[@id='profile-102org'])[1]"));
    public SelenideElement invalidEmailMessage = $(By.xpath("//p[contains(text(),'Please')]"));
    public SelenideElement invalidCredentialMessage = $(By.xpath("//p[contains(text(),'invalid.')]"));
    public SelenideElement userIcon = $(By.xpath("(//img[@data-test='profile-icon'])[2]"));
    public SelenideElement changePasswordMenu = $(By.xpath("(//a[@data-test='menu-reset'])[2]"));
    public SelenideElement updatePasswordTitle = $(By.xpath("(//div[@class='reset-title'])[2]"));
    public SelenideElement currentPasswordTextField = $(By.xpath("(//input[@data-test='reset-current'])[2]"));
    public SelenideElement newPasswordTextField = $(By.xpath("(//input[@data-test='reset-new'])[2]"));
    public SelenideElement repeatNewPasswordTextField = $(By.xpath("(//input[@data-test='reset-retype'])[2]"));
    public SelenideElement updateButton = $(By.xpath("(//div[.='Update'])[2]"));
    public SelenideElement attentionMessageTitle = $(By.xpath("//h3"));
    public SelenideElement attentionFirstLineMessage = $(By.xpath("//p[@class='info-text']"));
    public SelenideElement firstAssociation = $(By.xpath("(//ul[@class='domain-name ng-star-inserted']//li//div)[1]"));
    public SelenideElement secondAssociation = $(By.xpath("(//ul[@class='domain-name ng-star-inserted']//li//div)[2]"));
    public SelenideElement continueButton = $(By.xpath("//button[.=' Continue ']"));
    public SelenideElement buttonOkay = $(By.xpath("//button[.=' Okay ']"));



}
