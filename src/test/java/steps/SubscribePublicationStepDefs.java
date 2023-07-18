package steps;

import com.codeborne.selenide.Condition;
import org.junit.Assert;
import pages.ShopPage;
import utils.BrowserUtils;
import utils.ConfigurationReader;
import io.cucumber.java.en.Then;

import java.time.Duration;

import static com.codeborne.selenide.Selenide.$;

public class SubscribePublicationStepDefs {

    ShopPage shopPage=new ShopPage();


    @Then("user should be able to click shop")
    public void user_should_be_able_to_click_shop() {
        BrowserUtils.clickWithJS(shopPage.shopOnMain);
        BrowserUtils.wait(2);
    }

    @Then("user should be able to subscribe to a publication")
    public void user_should_be_able_to_subscribe_to_a_publication() {
        BrowserUtils.clickWithJS(shopPage.subscriptionOnShop);
        BrowserUtils.wait(2);
    }

    @Then("user should be able to one of publications")
    public void user_should_be_able_to_one_of_publications() {
        BrowserUtils.clickWithJS(shopPage.subsToPublication);
        BrowserUtils.wait(2);
    }

    @Then("user should be able to pay existing electronic payment and checkout")
    public void user_should_be_able_to_pay_existing_electronic_payment_and_checkout() {
        shopPage.familyHandymanIncrease.click();

        //SUBSCRIPTION DETAL PAGE
        Assert.assertEquals("The Family Handyman - LBA", shopPage.familyHandymanIncreaseTitle.shouldBe(Condition.visible, Duration.ofSeconds(5)).getText());
        shopPage.addToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        shopPage.continueToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        BrowserUtils.clickWithJS(shopPage.checkoutFamilyHandyman);
        BrowserUtils.wait(2);

//        shopPage.checkoutFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
//        BrowserUtils.clickWithJS(shopPage.electronicCheckPayment);
        shopPage.electronicCheckPayment.shouldBe(Condition.visible).click();

        BrowserUtils.wait(1);
        $(shopPage.existingAddress).scrollTo();
        shopPage.existingAddress.shouldBe(Condition.visible).click();
//        BrowserUtils.clickWithJS(shopPage.existingAddress);

        shopPage.lastCheckOut.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
//        shopPage.okayConfirmation.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        BrowserUtils.wait(2);

    }


    @Then("user should be able to pay existing pay later payment and checkout")
    public void user_should_be_able_to_pay_existing_pay_later_payment_and_checkout() {

        //BROWSE SUBSCRIPTION
        shopPage.familyHandymanIncrease.click();

        //SUBSCRIPTION DETAL PAGE
        Assert.assertEquals("The Family Handyman - LBA", shopPage.familyHandymanIncreaseTitle.shouldBe(Condition.visible, Duration.ofSeconds(5)).getText());
        shopPage.addToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        shopPage.continueToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        BrowserUtils.clickWithJS(shopPage.checkoutFamilyHandyman);
        BrowserUtils.wait(2);

        //CHECKOUT PAGE
        shopPage.payLaterOnCheckout.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        $(shopPage.existingAddress).scrollIntoView(true);
        shopPage.existingAddress.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        BrowserUtils.clickWithJS(shopPage.lastCheckOut);


    }


    @Then("user should be able to pay new payment method and checkout")
    public void user_should_be_able_to_pay_new_payment_method_and_checkout() {
        shopPage.familyHandymanIncrease.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        shopPage.addToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        shopPage.continueToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        shopPage.checkoutFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        BrowserUtils.clickWithJS(shopPage.newPaymentOnCheckout);
        shopPage.creditCard.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("creditCardAmex"));
        shopPage.nameOnCreditCard.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("nameOnCard"));
        shopPage.expMonth.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        BrowserUtils.clickWithJS(shopPage.mayExpireMonth);
        shopPage.expYear.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        BrowserUtils.clickWithJS(shopPage.tweentysixExpireYear);
        shopPage.securityCode.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys(ConfigurationReader.getProperty("SecurityCode"));
        BrowserUtils.clickWithJS(shopPage.existingAddress);
        shopPage.lastCheckOut.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        shopPage.closeButton.shouldBe(Condition.visible,Duration.ofSeconds(20)).click();
    }


    @Then("user should be able to view my subscriptions")
    public void user_should_be_able_to_view_my_subscriptions() {
        shopPage.viewMySubscriptions.click();
        BrowserUtils.wait(10);
    }


    @Then("a popup confirmation appear")
    public void aPopupConfirmationAppear() {
        //POPUP CONFIRMATION
        Assert.assertEquals("Thank you!",shopPage.thankYouMessage.shouldBe(Condition.visible,Duration.ofSeconds(20)).getText());
        Assert.assertEquals("Your order was successful "+ConfigurationReader.getProperty("username"),shopPage.orderSuccessfulMessage.shouldBe(Condition.visible,Duration.ofSeconds(20)).getText());
        shopPage.closeButton.click();
    }
}
