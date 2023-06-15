package steps;

import pages.MainPage;
import utils.BrowserUtils;
import utils.ConfigurationReader;
import io.cucumber.java.en.When;
import org.junit.Assert;

public class LoginOrganizationStepDefs {

    MainPage mainPage=new MainPage();

    @When("user should be able to login into users page with org credentials")
    public void user_should_be_able_to_login_into_users_page_with_org_credentials() {
        BrowserUtils.wait(2);
        mainPage.allowCookies.click();
        BrowserUtils.wait(3);

        Assert.assertEquals("Home", mainPage.homeOnMainPage.getText());
        Assert.assertEquals("Events", mainPage.eventsOnMainPage.getText());
        Assert.assertEquals("Community", mainPage.communityOnMainPage.getText());
        Assert.assertEquals("Shop", mainPage.shopOnMainPage.getText());
        Assert.assertEquals("Donations", mainPage.donationsOnMainPage.getText());
        Assert.assertEquals("Certifications", mainPage.certificationsOnMainPage.getText());
        Assert.assertNotNull(mainPage.cartOnMainPage);
        Assert.assertEquals("Welcome!", mainPage.welcomeOnMainPage.getText());


        mainPage.profileButton.click();
        BrowserUtils.wait(1);
        mainPage.loginOnProfile.click();
        BrowserUtils.wait(3);
        mainPage.usernameInput.sendKeys(ConfigurationReader.getProperty("username"));
        BrowserUtils.wait(1);
        mainPage.passwordInput.sendKeys(ConfigurationReader.getProperty("password"));
        BrowserUtils.wait(1);
        mainPage.signInButton.click();
        BrowserUtils.wait(10);
    }

    @When("user should be able to login into users page with org credentials with invalid org password")
    public void user_should_be_able_to_login_into_users_page_with_org_credentials_with_invalid_org_password() {

        BrowserUtils.wait(2);
        mainPage.allowCookies.click();
        BrowserUtils.wait(3);

        Assert.assertEquals("Home", mainPage.homeOnMainPage.getText());
        Assert.assertEquals("Events", mainPage.eventsOnMainPage.getText());
        Assert.assertEquals("Community", mainPage.communityOnMainPage.getText());
        Assert.assertEquals("Shop", mainPage.shopOnMainPage.getText());
        Assert.assertEquals("Donations", mainPage.donationsOnMainPage.getText());
        Assert.assertEquals("Certifications", mainPage.certificationsOnMainPage.getText());
        Assert.assertNotNull(mainPage.cartOnMainPage);
        Assert.assertEquals("Welcome!", mainPage.welcomeOnMainPage.getText());


        mainPage.profileButton.click();
        BrowserUtils.wait(1);
        mainPage.loginOnProfile.click();
        BrowserUtils.wait(3);
        mainPage.usernameInput.sendKeys(ConfigurationReader.getProperty("username"));
        BrowserUtils.wait(1);
        mainPage.passwordInput.sendKeys(ConfigurationReader.getProperty("invalidindividualpassword"));
        BrowserUtils.wait(1);
        mainPage.signInButton.click();
        BrowserUtils.wait(10);
    }

    @When("user should be able to login into users page with invalid org username")
    public void user_should_be_able_to_login_into_users_page_with_invalid_org_username() {


        BrowserUtils.wait(2);
        mainPage.allowCookies.click();
        BrowserUtils.wait(3);

        Assert.assertEquals("Home", mainPage.homeOnMainPage.getText());
        Assert.assertEquals("Events", mainPage.eventsOnMainPage.getText());
        Assert.assertEquals("Community", mainPage.communityOnMainPage.getText());
        Assert.assertEquals("Shop", mainPage.shopOnMainPage.getText());
        Assert.assertEquals("Donations", mainPage.donationsOnMainPage.getText());
        Assert.assertEquals("Certifications", mainPage.certificationsOnMainPage.getText());
        Assert.assertNotNull(mainPage.cartOnMainPage);
        Assert.assertEquals("Welcome!", mainPage.welcomeOnMainPage.getText());


        mainPage.profileButton.click();
        BrowserUtils.wait(1);
        mainPage.loginOnProfile.click();
        BrowserUtils.wait(3);
        mainPage.usernameInput.sendKeys(ConfigurationReader.getProperty("invalidindividualusername"));
        BrowserUtils.wait(1);
        mainPage.passwordInput.sendKeys(ConfigurationReader.getProperty("password"));
        BrowserUtils.wait(1);
        mainPage.signInButton.click();
        BrowserUtils.wait(10);
    }

    @When("user should be able to login into users page with org invalid username and password")
    public void user_should_be_able_to_login_into_users_page_with_org_invalid_username_and_password() {


        BrowserUtils.wait(2);
        mainPage.allowCookies.click();
        BrowserUtils.wait(3);

        Assert.assertEquals("Home", mainPage.homeOnMainPage.getText());
        Assert.assertEquals("Events", mainPage.eventsOnMainPage.getText());
        Assert.assertEquals("Community", mainPage.communityOnMainPage.getText());
        Assert.assertEquals("Shop", mainPage.shopOnMainPage.getText());
        Assert.assertEquals("Donations", mainPage.donationsOnMainPage.getText());
        Assert.assertEquals("Certifications", mainPage.certificationsOnMainPage.getText());
        Assert.assertNotNull(mainPage.cartOnMainPage);
        Assert.assertEquals("Welcome!", mainPage.welcomeOnMainPage.getText());


        mainPage.profileButton.click();
        BrowserUtils.wait(1);
        mainPage.loginOnProfile.click();
        BrowserUtils.wait(3);
        mainPage.usernameInput.sendKeys(ConfigurationReader.getProperty("invalidindividualusername"));
        BrowserUtils.wait(1);
        mainPage.passwordInput.sendKeys(ConfigurationReader.getProperty("invalidindividualpassword"));
        BrowserUtils.wait(1);
        mainPage.signInButton.click();
        BrowserUtils.wait(10);

    }



}
