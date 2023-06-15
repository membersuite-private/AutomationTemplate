package steps;
import pages.MainPage;
import utils.BrowserUtils;
import utils.ConfigurationReader;
import io.cucumber.java.en.When;
import org.junit.Assert;
public class LoginIndividualStepDefs {
    MainPage mainPage= new MainPage();


    @When("user should be able to login into users page with invalid individual password")
    public void user_should_be_able_to_login_into_users_page_with_invalid_password() {

        BrowserUtils.wait(2);
        mainPage.allowCookies.click();
        BrowserUtils.wait(3);

        Assert.assertTrue(mainPage.homeOnMainPage.getText().equals("Home"));
        Assert.assertTrue(mainPage.eventsOnMainPage.getText().equals("Events"));
        Assert.assertTrue(mainPage.communityOnMainPage.getText().equals("Community"));
        Assert.assertTrue(mainPage.shopOnMainPage.getText().equals("Shop"));
        Assert.assertTrue(mainPage.donationsOnMainPage.getText().equals("Donations"));
        Assert.assertTrue(mainPage.certificationsOnMainPage.getText().equals("Certifications"));
        Assert.assertNotNull(mainPage.cartOnMainPage);
        Assert.assertTrue(mainPage.welcomeOnMainPage.getText().equals("Welcome!"));


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


    @When("user should be able to login into users page with invalid individual username")
    public void user_should_be_able_to_login_into_users_page_with_invalid_individual_username() {

        BrowserUtils.wait(2);
        mainPage.allowCookies.click();
        BrowserUtils.wait(3);

        Assert.assertTrue(mainPage.homeOnMainPage.getText().equals("Home"));
        Assert.assertTrue(mainPage.eventsOnMainPage.getText().equals("Events"));
        Assert.assertTrue(mainPage.communityOnMainPage.getText().equals("Community"));
        Assert.assertTrue(mainPage.shopOnMainPage.getText().equals("Shop"));
        Assert.assertTrue(mainPage.donationsOnMainPage.getText().equals("Donations"));
        Assert.assertTrue(mainPage.certificationsOnMainPage.getText().equals("Certifications"));
        Assert.assertNotNull(mainPage.cartOnMainPage);
        Assert.assertTrue(mainPage.welcomeOnMainPage.getText().equals("Welcome!"));


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

    @When("user should be able to login into users page with invalid username and password")
    public void user_should_be_able_to_login_into_users_page_with_invalid_username_and_password() {

        BrowserUtils.wait(2);
        mainPage.allowCookies.click();
        BrowserUtils.wait(3);

        Assert.assertTrue(mainPage.homeOnMainPage.getText().equals("Home"));
        Assert.assertTrue(mainPage.eventsOnMainPage.getText().equals("Events"));
        Assert.assertTrue(mainPage.communityOnMainPage.getText().equals("Community"));
        Assert.assertTrue(mainPage.shopOnMainPage.getText().equals("Shop"));
        Assert.assertTrue(mainPage.donationsOnMainPage.getText().equals("Donations"));
        Assert.assertTrue(mainPage.certificationsOnMainPage.getText().equals("Certifications"));
        Assert.assertNotNull(mainPage.cartOnMainPage);
        Assert.assertTrue(mainPage.welcomeOnMainPage.getText().equals("Welcome!"));


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

