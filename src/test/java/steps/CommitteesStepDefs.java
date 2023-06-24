package steps;

import com.codeborne.selenide.Condition;
import io.cucumber.java.en.And;
import io.cucumber.java.en.When;
import pages.CommunityPage;
import pages.MainPage;
import utils.BrowserUtils;
import io.cucumber.java.en.Then;
import org.junit.Assert;
import utils.ConfigurationReader;
import utils.Utils;

import java.time.Duration;

public class CommitteesStepDefs {

    CommunityPage communityPage=new CommunityPage();
    MainPage mainPage = new MainPage();

    @When("user should be able to login into users page")
    public void user_should_be_able_to_login_into_users_page() {
        mainPage.loginSignup.click();

        BrowserUtils.clickWithJS(mainPage.loginOption);
        BrowserUtils.wait(3);

        mainPage.emailInput.sendKeys(ConfigurationReader.getProperty("username"));
        mainPage.passInput.sendKeys(ConfigurationReader.getProperty("password"));

        BrowserUtils.clickWithJS(mainPage.signinButton);
        BrowserUtils.wait(3);
    }

    @Then("user should be able to click community")
    public void user_should_be_able_to_click_community() {

        communityPage.communityOnMain.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        BrowserUtils.wait(2);

    }

    @Then("user should be able to click browse committees")
    public void user_should_be_able_to_click_browse_committees() {
        BrowserUtils.clickWithJS(communityPage.committeesOnCommunity);
        communityPage.browseCommitteesOnCommittees.click();
    }

    @Then("user should be able to verify one of the committees")
    public void user_should_be_able_to_verify_one_of_the_committees() {
//        communityPage.committeeTypesOnBrowseCommittees.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
//        BrowserUtils.wait(3);
//        BrowserUtils.clickWithJS(communityPage.typeBOnCommitteeTypes);
        BrowserUtils.wait(2);
        Assert.assertEquals("New testing committee",communityPage.committeeTwoOnBrowseAllCommittees.getText());

    }

    @Then("user should be able to click my committees")
    public void user_should_be_able_to_click_my_committees() {
        communityPage.viewMyCommitteesOnCommittees.click();
        BrowserUtils.wait(3);
    }

    @Then("user should be able to verify one of the my committees")
    public void user_should_be_able_to_verify_one_of_the_my_committees() {

//        Assert.assertTrue(communityPage.closedcommittesOnCommittee.getText().equals("Closed committee"));
        Assert.assertTrue(communityPage.currentCommitteeMembershipOnCommittees.getText().equals("Current Committee Membership"));
        BrowserUtils.wait(1);
        communityPage.browseAllCommittees.click();
        BrowserUtils.wait(2);

    }


    @And("user should be able to click committees")
    public void userShouldBeAbleToClickCommittees() {
        BrowserUtils.clickWithJS(communityPage.committeesMenu);
    }
}
