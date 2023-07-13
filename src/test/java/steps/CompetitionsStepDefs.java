package steps;

import com.codeborne.selenide.Condition;
import org.junit.Assert;
import pages.CommunityPage;
import utils.BrowserUtils;
import io.cucumber.java.en.Then;

import java.time.Duration;

public class CompetitionsStepDefs {


    CommunityPage communityPage=new CommunityPage();

    @Then("user should be able to click view competitions on competitions")
    public void user_should_be_able_to_click_view_competitions_on_competitions() {

        communityPage.competitionsOnCommunity.click();
        BrowserUtils.wait(1);
        communityPage.viewOpenCompetitionsOnCompetitions.click();
        BrowserUtils.wait(6);

    }

    @Then("user should be able to choose competition type on view competitions")
    public void user_should_be_able_to_choose_competition_type_on_view_competitions() {

        BrowserUtils.clickWithJS(communityPage.competitionTypeOnBrowseCompetitions);
        BrowserUtils.wait(1);
        communityPage.competitionType1OnCompTypeOnBrowseCompetitions.click();
        BrowserUtils.wait(4);

    }

    @Then("user should be able to select one of competitions")
    public void user_should_be_able_to_select_one_of_competitions() {
        communityPage.fancyCompetitionOnBrowseCompetition.click();
        BrowserUtils.wait(3);

    }

    @Then("user should be able to enter and arrange entry fee")
    public void user_should_be_able_to_enter_and_arrange_entry_fee() {
        communityPage.enterNowOnFancyCompetition.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    }

    @Then("user should be able to fill out information and save as draft on competition")
    public void user_should_be_able_to_fill_out_information_and_save_as_draft_on_competition() {
        communityPage.nameOnEntryForm.shouldBe(Condition.visible,Duration.ofSeconds(10)).sendKeys("Test");
        BrowserUtils.wait(1);
        BrowserUtils.clickWithJS(communityPage.saveAsDraftOnEntryFee);
        BrowserUtils.wait(1);
        communityPage.goHomeOnEntryConfirm.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        BrowserUtils.wait(2);

    }

    @Then("user should be able to click view my competitions on competitions")
    public void user_should_be_able_to_click_view_my_competitions_on_competitions() {
        communityPage.competitionsOnCommunity.click();
        BrowserUtils.wait(2);
        BrowserUtils.clickWithJS(communityPage.viewMyCompetitionEntriesOnCompetitions);
    }

    @Then("user should be able to see one of the competitions")
    public void user_should_be_able_to_see_one_of_the_competitions() {
        communityPage.viewFirstOnMyCompetitionEntriesOnCompetitions.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    }


    @Then("user should be able to click judging center on competitions")
    public void user_should_be_able_to_click_judging_center_on_competitions() {
        communityPage.competitionsOnCommunity.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        communityPage.judgingCenterOnCompetition.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
    }

    @Then("user should be able to see one of the judgin bucket")
    public void user_should_be_able_to_see_one_of_the_judgin_bucket() {
        Assert.assertEquals("Tum on at 10 competition", communityPage.viewScoresOnJudginCenter.shouldBe(Condition.visible, Duration.ofSeconds(5)).getText());
    }

}
