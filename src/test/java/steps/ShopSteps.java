package steps;

import com.codeborne.selenide.Condition;
import io.cucumber.java.en.And;
import io.cucumber.java.en.Then;
import io.cucumber.junit.Cucumber;
import org.junit.Assert;
import pages.ShopPage;
import utils.BrowserUtils;
import utils.ConfigurationReader;
import utils.Utils;

import java.time.Duration;

import static com.codeborne.selenide.Selenide.$;

public class ShopSteps {
    ShopPage shopPage = new ShopPage();

    @And("user should be able to click Browse")
    public void user_should_be_able_to_click_browse() {
        BrowserUtils.clickWithJS(shopPage.browseOnShop);
        BrowserUtils.wait(2);
    }


    @And("user should be able to pay for a product using an existing electronic payment and checkout")
    public void userShouldBeAbleToPayForAProductUsingAnExistingElectronicPaymentAndCheckout() {
        BrowserUtils.clickWithJS(shopPage.bluePayProduct);
//        shopPage.bluePayProduct.click();

        //SUBSCRIPTION DETAL PAGE
        Assert.assertEquals("BluePay", shopPage.BluePayTitle.shouldBe(Condition.visible, Duration.ofSeconds(5)).getText());
        BrowserUtils.clickWithJS(shopPage.addToCartFamilyHandyman);
        //        shopPage.addToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        shopPage.continueToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        BrowserUtils.clickWithJS(shopPage.checkoutFamilyHandyman);
        BrowserUtils.wait(2);
        shopPage.electronicCheckPayment.shouldBe(Condition.visible).click();

        BrowserUtils.wait(1);
        $(shopPage.existingAddress).scrollTo();
        shopPage.existingAddress.shouldBe(Condition.visible).click();

        shopPage.lastCheckOut.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        BrowserUtils.wait(2);
    }

    @Then("a Thank You message appear")
    public void aThankYouMessageAppear() {
        //POPUP CONFIRMATION
        Assert.assertEquals("Thank you!",shopPage.thankYouMessageShop.shouldBe(Condition.visible,Duration.ofSeconds(20)).getText());
        Assert.assertEquals("Order Successful "+ ConfigurationReader.getProperty("username"),shopPage.orderSuccessfulMessageShop.shouldBe(Condition.visible,Duration.ofSeconds(20)).getText());
        
        shopPage.closeButton.click();
    }

    @And("user should be able to pay for a product using a new electronic payment and checkout")
    public void userShouldBeAbleToPayForAProductUsingANewElectronicPaymentAndCheckout() {
        BrowserUtils.clickWithJS(shopPage.bluePayProduct);
//        shopPage.bluePayProduct.click();

        //SUBSCRIPTION DETAL PAGE
        Assert.assertEquals("BluePay", shopPage.BluePayTitle.shouldBe(Condition.visible, Duration.ofSeconds(5)).getText());
        BrowserUtils.clickWithJS(shopPage.addToCartFamilyHandyman);
        //        shopPage.addToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        shopPage.continueToCartFamilyHandyman.shouldBe(Condition.visible,Duration.ofSeconds(5)).click();
        BrowserUtils.clickWithJS(shopPage.checkoutFamilyHandyman);
        BrowserUtils.wait(2);

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
    }
}
