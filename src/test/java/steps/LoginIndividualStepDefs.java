package steps;
import com.codeborne.selenide.Condition;
import io.cucumber.java.en.And;
import io.cucumber.java.en.Then;
import org.openqa.selenium.Keys;
import pages.MainPage;
import utils.BrowserUtils;
import utils.ConfigurationReader;
import io.cucumber.java.en.When;
import org.junit.Assert;

import java.time.Duration;

public class LoginIndividualStepDefs {
    MainPage mainPage= new MainPage();


    @When("user should be able to login into users page with invalid individual password")
    public void user_should_be_able_to_login_into_users_page_with_invalid_password() {
        BrowserUtils.clickWithJS(mainPage.loginOption);
        BrowserUtils.wait(3);

        mainPage.emailInput.sendKeys(ConfigurationReader.getProperty("username"));
        mainPage.passInput.sendKeys(ConfigurationReader.getProperty("invalidindividualpassword"));

        BrowserUtils.clickWithJS(mainPage.signinButton);
        BrowserUtils.wait(3);
        mainPage.invalidCredentialMessage.shouldBe(Condition.visible, Duration.ofSeconds(10));
        Assert.assertEquals("Login credentials were invalid.", mainPage.invalidCredentialMessage.getText());

    }


    @When("user should be able to login into users page with invalid individual username")
    public void user_should_be_able_to_login_into_users_page_with_invalid_individual_username() {
        BrowserUtils.clickWithJS(mainPage.loginOption);
        BrowserUtils.wait(3);

        mainPage.emailInput.sendKeys(ConfigurationReader.getProperty("invalidindividualusername"));
        mainPage.passInput.sendKeys(ConfigurationReader.getProperty("password"));

        BrowserUtils.clickWithJS(mainPage.signinButton);
        BrowserUtils.wait(3);
        mainPage.invalidEmailMessage.shouldBe(Condition.visible, Duration.ofSeconds(10));
        Assert.assertEquals("Please enter a valid email address.", mainPage.invalidEmailMessage.getText());


    }

    @When("user should be able to login into users page with invalid username and password")
    public void user_should_be_able_to_login_into_users_page_with_invalid_username_and_password() {
        BrowserUtils.clickWithJS(mainPage.loginOption);
        BrowserUtils.wait(3);

        mainPage.emailInput.sendKeys(ConfigurationReader.getProperty("invalidindividualusername"));
        mainPage.passInput.sendKeys(ConfigurationReader.getProperty("invalidindividualpassword"));

        BrowserUtils.clickWithJS(mainPage.signinButton);
        BrowserUtils.wait(3);
        mainPage.invalidEmailMessage.shouldBe(Condition.visible, Duration.ofSeconds(10));
        Assert.assertEquals("Please enter a valid email address.", mainPage.invalidEmailMessage.getText());

    }


    @When("user should be able to login with an account that exists in many associations")
    public void userShouldBeAbleToLoginWithAnAccountThatExistsInManyAssociations() {
        mainPage.allowCookies.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        mainPage.loginSignup.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();

        BrowserUtils.clickWithJS(mainPage.loginOption);

        mainPage.emailInput.sendKeys("user_associations@yop.com");
        mainPage.passInput.sendKeys("Password1!");

        BrowserUtils.clickWithJS(mainPage.signinButton);
    }

    @And("click to change password")
    public void clickToChangePassword() {
        mainPage.userIcon.click();
        mainPage.changePasswordMenu.click();
    }

    @And("fill the form with the new password")
    public void fillTheFormWithTheNewPassword() {
        mainPage.updatePasswordTitle.shouldBe(Condition.visible,Duration.ofSeconds(10));
        mainPage.currentPasswordTextField.setValue("Password1!");

        mainPage.currentPasswordTextField.sendKeys(Keys.ALT);
        mainPage.newPasswordTextField.setValue("Password1!");

        mainPage.newPasswordTextField.sendKeys(Keys.ALT);
        mainPage.repeatNewPasswordTextField.setValue("Password1!");
        mainPage.repeatNewPasswordTextField.sendKeys(Keys.ALT);
        mainPage.repeatNewPasswordTextField.sendKeys(Keys.ENTER);
        BrowserUtils.wait(3);
    }

    @And("click Update")
    public void clickUpdate() {
//        BrowserUtils.clickWithJS(mainPage.updateButton);
    }

    @Then("an Attention message should appear")
    public void anAttentionMessageShouldAppear() {
        mainPage.attentionMessageTitle.shouldBe(Condition.visible);
        Assert.assertEquals("Attention!", mainPage.attentionMessageTitle.getText());
        mainPage.attentionFirstLineMessage.shouldBe(Condition.visible);
        Assert.assertEquals("It appears that you have an account in multiple associations. Your password will be updated for the following associations:", mainPage.attentionFirstLineMessage.getText());
        mainPage.firstAssociation.shouldBe(Condition.visible);
        Assert.assertEquals("QA Leesa Purple", mainPage.firstAssociation.getText());
        mainPage.secondAssociation.shouldBe(Condition.visible);
        Assert.assertEquals("MRP BluePay Automation Purple", mainPage.secondAssociation.getText());
        mainPage.continueButton.click();

    }
}

