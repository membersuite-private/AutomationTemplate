package pages;

import com.codeborne.selenide.SelenideElement;
import org.openqa.selenium.By;


import static com.codeborne.selenide.Selenide.$;

public class ShopPage {
    
    public SelenideElement shopOnMain = $(By.xpath("//div[contains(text(),'Shop')]"));
    public SelenideElement subscriptionOnShop = $(By.xpath("//div[contains(text(),'Subscriptions')]"));
    public SelenideElement browseOnShop = $(By.xpath("//div[contains(text(),'Browse')]"));
    public SelenideElement subsToPublication = $(By.xpath("//div[contains(text(),'Subscribe to a Publication')]"));
    public SelenideElement familyHandymanIncrease = $(By.xpath("//h4[.='The Family Handyman - LBA']"));
    public SelenideElement bluePayProduct = $(By.xpath("//span[.='BluePay']"));
    public SelenideElement familyHandymanIncreaseTitle = $(By.xpath("//p[@class='publication-name']"));
    public SelenideElement BluePayTitle = $(By.xpath("//div[@data-test='product-name-desktop']"));
    public SelenideElement addToCartFamilyHandyman = $(By.xpath("//button"));
    public SelenideElement continueToCartFamilyHandyman = $(By.xpath("//button[.=' Continue to Cart ']"));
    public SelenideElement checkoutFamilyHandyman = $(By.xpath("//button[@data-test='checkout-button']"));
    public SelenideElement electronicCheckPayment = $(By.xpath("//span[@data-test-id='saved-payment-name']"));
    public SelenideElement existingAddress = $(By.xpath("(//div[@class='mat-radio-inner-circle'])[4]"));
    public SelenideElement lastCheckOut = $(By.xpath("//button[.=' Checkout ']"));
    public SelenideElement thankYouMessage = $(By.xpath("(//div[.=' Thank you! '])[2]"));
    public SelenideElement thankYouMessageShop = $(By.xpath("//div[.='Thank you! ']"));
    public SelenideElement orderSuccessfulMessage = $(By.xpath("//div[@class='title ng-star-inserted']"));
    public SelenideElement orderSuccessfulMessageShop = $(By.xpath("//div[@class='col-12 no-padding message ng-star-inserted']"));
    public SelenideElement okayConfirmation = $(By.xpath("//button[normalize-space()='Okay']"));
    public SelenideElement closeButton = $(By.xpath("//button[.=' Close ']"));
    public SelenideElement payLaterOnCheckout = $(By.xpath("(//div[@class='mat-radio-label-content'])[3]"));
    public SelenideElement newPaymentOnCheckout = $(By.xpath("(//input[@name='paymentOption'])[2]"));
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
