package steps;

import com.codeborne.selenide.Condition;
import pages.CommunityPage;
import utils.BrowserUtils;
import io.cucumber.java.en.Then;
import org.junit.Assert;

import java.time.Duration;

public class DiscussionsStepDefs {

    CommunityPage communityPage=new CommunityPage();

    @Then("user should be able to click view Discussion Board on Discussions")
    public void user_should_be_able_to_click_view_Discussion_Board_on_Discussions() {
        communityPage.discussionsOnCommunity.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        communityPage.viewDiscussionBoardOnDiscussions.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    }

    @Then("user should be able to verify view Discussion Board")
    public void user_should_be_able_to_verify_view_Discussion_Board() {
        Assert.assertEquals("Favorite hobby",communityPage.discussionBoardTextOnDiscussions.getText());
        communityPage.subscribeForumOneOnDiscussionBoard.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        communityPage.unsubscribeForumOneOnDiscussionBoard.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    }

    @Then("user should be able to see one of the discussion boards")
    public void user_should_be_able_to_see_one_of_the_discussion_boards() {
        communityPage.forumOneNotMembersOnDiscussionBoard.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        communityPage.musicStreamingOnForumOne.shouldBe(Condition.visible, Duration.ofSeconds(10)).click();
    }

    @Then("user should be able to click view my Topic Subscriptions")
    public void user_should_be_able_to_click_view_my_Topic_Subscriptions() {
        communityPage.discussionsOnCommunity.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        communityPage.viewMyTopicSubscriptionsOnDiscussions.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    }

    @Then("user should be able to verify view my Topic Subscriptions")
    public void user_should_be_able_to_verify_view_my_Topic_Subscriptions() {
        communityPage.oneoftheforumOnTopicSubscriptions.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    }

}
