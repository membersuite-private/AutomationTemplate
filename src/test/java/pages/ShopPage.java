package pages;

import com.codeborne.selenide.SelenideElement;
import org.openqa.selenium.By;


import static com.codeborne.selenide.Selenide.$;

public class ShopPage {
    
    public SelenideElement shopOnMain = $(By.xpath("//div[contains(text(),'Shop')]"));
    public SelenideElement subscriptionOnShop = $(By.xpath("//div[contains(text(),'Subscriptions')]"));
    public SelenideElement subsToPublication = $(By.xpath("//div[contains(text(),'Subscribe to a Publication')]"));
    public SelenideElement familyHandymanIncrease = $(By.xpath("//h4[.='The Family Handyman - LBA']"));
    public SelenideElement familyHandymanIncreaseTitle = $(By.xpath("//p[@class='publication-name']"));
    public SelenideElement addToCartFamilyHandyman = $(By.xpath("//button"));
    public SelenideElement continueToCartFamilyHandyman = $(By.xpath("//button[.=' Continue to Cart ']"));
    public SelenideElement checkoutFamilyHandyman = $(By.xpath("//button[@data-test='checkout-button']"));
    public SelenideElement electronicCheckPayment = $(By.xpath("//label[@for='mat-radio-7-input']//div[@class='mat-radio-inner-circle']"));
    public SelenideElement existingAddress = $(By.xpath("(//div[@class='mat-radio-label-content'])[3]"));
    public SelenideElement lastCheckOut = $(By.xpath("//button[.=' Checkout ']"));
    public SelenideElement thankYouMessage = $(By.xpath("(//div[.=' Thank you! '])[2]"));
    public SelenideElement orderSuccessfulMessage = $(By.xpath("//div[@class='title ng-star-inserted']"));
    public SelenideElement okayConfirmation = $(By.xpath("//button[normalize-space()='Okay']"));
    public SelenideElement closeButton = $(By.xpath("//button[.=' Close ']"));
    public SelenideElement payLaterOnCheckout = $(By.xpath("(//div[@class='mat-radio-label-content'])[2]"));
    public SelenideElement newPaymentOnCheckout = $(By.xpath("(//div[@class='mat-radio-inner-circle'])[10]"));
    public SelenideElement creditCard = $(By.id("mat-input-1"));
    public SelenideElement nameOnCreditCard = $(By.id("mat-input-2"));
    public SelenideElement expMonth = $(By.id("mat-select-1"));
    public SelenideElement mayExpireMonth = $(By.id("mat-option-6"));
    public SelenideElement expYear = $(By.id("mat-select-2"));
    public SelenideElement tweentysixExpireYear = $(By.id("mat-option-18"));
    public SelenideElement securityCode = $(By.id("mat-input-3"));
    public SelenideElement viewMySubscriptions = $(By.xpath("//div[contains(text(),'View My Subscriptions')]"));
    

    /**
     * reusable login method
     * just call this method to login
     * provide username and password as parameters
     *
     * @param username
      @param password
     */




}
