package steps;

import com.codeborne.selenide.Condition;
import com.codeborne.selenide.Selenide;
import io.cucumber.java.en.And;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;

import org.junit.Assert;
import pages.MainPage;
import utils.ConfigurationReader;

import pages.LoginPage;

import java.time.Duration;


public class LoginStep {

    LoginPage login = new LoginPage();
    MainPage mainPage = new MainPage();


    @And("wait {int}sec")
    public void waitSec(int arg0) {
        Selenide.sleep(arg0);
    }

    @And("click on LoginButton")
    public void clickOnLoginBtn() {
//        mainPage.loginSignup.click();
    }

    @And("type not valid Username")
    public void typeInvalidUsername() {
        String username = ConfigurationReader.getProperty("username")+"123";
        login.inputUsername.sendKeys(username);

    }

    @And("type Username field")
    public void typeOnCompleteUsernamefield() {
        String username = ConfigurationReader.getProperty("username");
        login.inputUsername.sendKeys(username);
    }

    @And("type Password field")
    public void typeOnPasswordfield() {
        String password = ConfigurationReader.getProperty("password");
        login.inputPassword.sendKeys(password);
    }



    @Given("are on the application's page")
    public void areOnTheApplicationSLoginPage() {
        Assert.assertTrue(mainPage.homeOnMainPage.shouldBe(Condition.visible, Duration.ofSeconds(10)).getText().equals("Home"));
        Assert.assertTrue(mainPage.eventsOnMainPage.shouldBe(Condition.visible, Duration.ofSeconds(10)).getText().equals("Events"));
        Assert.assertTrue(mainPage.communityOnMainPage.shouldBe(Condition.visible, Duration.ofSeconds(10)).getText().equals("Community"));
        Assert.assertTrue(mainPage.shopOnMainPage.shouldBe(Condition.visible, Duration.ofSeconds(10)).getText().equals("Shop"));
        Assert.assertTrue(mainPage.donationsOnMainPage.shouldBe(Condition.visible, Duration.ofSeconds(10)).getText().equals("Donations"));
        Assert.assertTrue(mainPage.certificationsOnMainPage.shouldBe(Condition.visible, Duration.ofSeconds(10)).getText().equals("Certifications"));
        Assert.assertNotNull(mainPage.cartOnMainPage);
        Assert.assertTrue(mainPage.welcomeOnMainPage.shouldBe(Condition.visible, Duration.ofSeconds(10)).getText().equals("Welcome!"));
    }

    @Given("are on the association's page")
    public void areOnTheAssociationsPage() {
        login.WelcomeBanner.shouldBe(Condition.visible);
    }

    @Then("the user should login")
    public void theUserShouldLogin() {
    }

    @Then("should appear {string} message")
    public void shouldAppearMessage(String message) {
        Assert.assertEquals(message,login.message.getText());

    }

    @And("main page appear")
    public void mainPageAppear() {
        Assert.assertEquals(login.nameHead.getText(),"Hi, Levi Santos");

    }
}
