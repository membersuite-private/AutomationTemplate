package steps;
import com.codeborne.selenide.Condition;
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






}

