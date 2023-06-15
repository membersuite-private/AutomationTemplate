package steps;

import pages.CommunityPage;
import utils.BrowserUtils;
import io.cucumber.java.bs.A;
import io.cucumber.java.en.Then;
import org.junit.Assert;

public class CommitteesStepDefs {

    CommunityPage communityPage=new CommunityPage();

    @Then("user should be able to click community")
    public void user_should_be_able_to_click_community() {

        communityPage.communityOnMain.click();
        BrowserUtils.wait(1);

    }

    @Then("user should be able to click browse committees")
    public void user_should_be_able_to_click_browse_committees() {
        communityPage.committeesOnCommunity.click();
        BrowserUtils.wait(2);
        communityPage.browseCommitteesOnCommittees.click();
    }

    @Then("user should be able to verify one of the committees")
    public void user_should_be_able_to_verify_one_of_the_committees() {

        BrowserUtils.wait(2);
        BrowserUtils.clickWithJS(communityPage.committeeTypesOnBrowseCommittees);
  //      communityPage.committeeTypesOnBrowseCommittees.click();
        BrowserUtils.wait(1);
        communityPage.typeBOnCommitteeTypes.click();
        BrowserUtils.wait(3);
        Assert.assertTrue(communityPage.committeeTwoOnBrowseAllCommittees.getText().equals("Committee Two"));

    }



    @Then("user should be able to click my committees")
    public void user_should_be_able_to_click_my_committees() {


//        communityPage.committeesOnCommunity.click();
        BrowserUtils.wait(2);
        communityPage.viewMyCommitteesOnCommittees.click();
        BrowserUtils.wait(3);
    }

    @Then("user should be able to verify one of the my committees")
    public void user_should_be_able_to_verify_one_of_the_my_committees() {

        Assert.assertTrue(communityPage.closedcommittesOnCommittee.getText().equals("Closed committee"));
        Assert.assertTrue(communityPage.currentCommitteeMembershipOnCommittees.getText().equals("Current Committee Membership"));
        BrowserUtils.wait(1);
        communityPage.browseAllCommittees.click();
        BrowserUtils.wait(2);

    }



}
