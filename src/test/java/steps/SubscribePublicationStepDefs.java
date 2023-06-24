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
        BrowserUtils.clickWithJS(shopPage.electronicCheckPayment);

        BrowserUtils.wait(1);
        BrowserUtils.clickWithJS(shopPage.existingAddress);

        shopPage.lastCheckOut.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        shopPage.okayConfirmation.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        BrowserUtils.wait(25);

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
       BrowserUtils.wait(2);
        shopPage.familyHandymanIncrease.click();
        BrowserUtils.wait(2);
        shopPage.addToCartFamilyHandyman.click();
        BrowserUtils.wait(2);
        shopPage.continueToCartFamilyHandyman.click();
        BrowserUtils.wait(2);
        shopPage.checkoutFamilyHandyman.click();
        BrowserUtils.wait(2);
        BrowserUtils.clickWithJS(shopPage.newPaymentOnCheckout);
        BrowserUtils.wait(2);
        shopPage.creditCard.sendKeys(ConfigurationReader.getProperty("creditCardAmex"));
        BrowserUtils.wait(2);
        shopPage.nameOnCreditCard.sendKeys(ConfigurationReader.getProperty("nameOnCard"));
        BrowserUtils.wait(2);
        shopPage.expMonth.click();
        BrowserUtils.wait(1);
        BrowserUtils.clickWithJS(shopPage.mayExpireMonth);
        BrowserUtils.wait(2);
        shopPage.expYear.click();
        BrowserUtils.wait(1);
        BrowserUtils.clickWithJS(shopPage.tweentysixExpireYear);
        BrowserUtils.wait(2);
        shopPage.securityCode.sendKeys(ConfigurationReader.getProperty("SecurityCode"));
        BrowserUtils.wait(2);
        BrowserUtils.clickWithJS(shopPage.existingAddress);
        //   shopPage.existingAddress.click();
        BrowserUtils.wait(1);
        shopPage.lastCheckOut.click();
        BrowserUtils.wait(3);
        shopPage.okayConfirmation.click();
        BrowserUtils.wait(25);
        shopPage.closeButton.click();
    }



    @Then("user should be able to view my subscriptions")
    public void user_should_be_able_to_view_my_subscriptions() {
        shopPage.viewMySubscriptions.click();
        BrowserUtils.wait(10);
    }


    @Then("a popup confirmation appear")
    public void aPopupConfirmationAppear() {
        //POPUP CONFIRMATION
        Assert.assertEquals("Thank you!",shopPage.thankYouMessage.shouldBe(Condition.visible,Duration.ofSeconds(10)).getText());
        Assert.assertEquals("Your order was successful "+ConfigurationReader.getProperty("username"),shopPage.orderSuccessfulMessage.shouldBe(Condition.visible,Duration.ofSeconds(10)).getText());
        shopPage.closeButton.click();
    }
}
