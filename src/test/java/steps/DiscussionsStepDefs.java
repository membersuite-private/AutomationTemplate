package steps;

import pages.CommunityPage;
import utils.BrowserUtils;
import io.cucumber.java.en.Then;
import org.junit.Assert;

public class DiscussionsStepDefs {

    CommunityPage communityPage=new CommunityPage();

    @Then("user should be able to click view Discussion Board on Discussions")
    public void user_should_be_able_to_click_view_Discussion_Board_on_Discussions() {

        communityPage.discussionsOnCommunity.click();
        BrowserUtils.wait(1);
        communityPage.viewDiscussionBoardOnDiscussions.click();
        BrowserUtils.wait(5);

    }

    @Then("user should be able to verify view Discussion Board")
    public void user_should_be_able_to_verify_view_Discussion_Board() {

        Assert.assertTrue(communityPage.discussionBoardTextOnDiscussions.getText().equals("Kelly Gills PRD Discussion Board"));
        Assert.assertTrue(communityPage.warningOnDiscussionBoard.getText().equals("You may have to register before you can post. To start viewing messages, select the forum that you want to visit from the selection below."));
        communityPage.subscribeForumOneOnDiscussionBoard.click();
        BrowserUtils.wait(4);
        communityPage.unsubscribeForumOneOnDiscussionBoard.click();
        BrowserUtils.wait(5);
    }

    @Then("user should be able to see one of the discussion boards")
    public void user_should_be_able_to_see_one_of_the_discussion_boards() {

        communityPage.forumOneNotMembersOnDiscussionBoard.click();
        BrowserUtils.wait(3);
        communityPage.musicStreamingOnForumOne.click();
        BrowserUtils.wait(3);

    }

    @Then("user should be able to click view my Topic Subscriptions")
    public void user_should_be_able_to_click_view_my_Topic_Subscriptions() {

        communityPage.discussionsOnCommunity.click();
        BrowserUtils.wait(1);
        communityPage.viewMyTopicSubscriptionsOnDiscussions.click();
        BrowserUtils.wait(5);

    }

    @Then("user should be able to verify view my Topic Subscriptions")
    public void user_should_be_able_to_verify_view_my_Topic_Subscriptions() {

        communityPage.oneoftheforumOnTopicSubscriptions.click();
        BrowserUtils.wait(3);

    }

}
