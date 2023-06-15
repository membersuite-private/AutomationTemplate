package steps;

import pages.CommunityPage;
import utils.BrowserUtils;
import io.cucumber.java.en.Then;

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
 //       communityPage.competitionTypeOnBrowseCompetitions.click();
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

        communityPage.enterNowOnFancyCompetition.click();
        BrowserUtils.wait(4);
        communityPage.addCompetitionFee.click();
        BrowserUtils.wait(2);
        communityPage.entryTypeOnEntryFee.click();
        BrowserUtils.wait(1);
        communityPage.entryType1OnEntryTypeEntryFee.click();
        BrowserUtils.wait(1);
        communityPage.nextOnEntryFee.click();
        BrowserUtils.wait(2);

    }

    @Then("user should be able to fill out information and save as draft on competition")
    public void user_should_be_able_to_fill_out_information_and_save_as_draft_on_competition() {


        communityPage.nameOnEntryForm.sendKeys("Test");
        BrowserUtils.wait(1);
        communityPage.whatColorSocksOnEntry.sendKeys("Dark Blue");
        BrowserUtils.wait(1);
        communityPage.enterTheAlphateOnEntryFee.sendKeys("MemberSuite");
        BrowserUtils.wait(1);
        communityPage.saveAsDraftOnEntryFee.click();
        BrowserUtils.wait(1);
        communityPage.goHomeOnEntryConfirm.click();
        BrowserUtils.wait(2);

    }



    @Then("user should be able to click view my competitions on competitions")
    public void user_should_be_able_to_click_view_my_competitions_on_competitions() {


        communityPage.competitionsOnCommunity.click();
        BrowserUtils.wait(2);
//        communityPage.viewMyCompetitionEntriesOnCompetitions.click();
        BrowserUtils.clickWithJS(communityPage.viewMyCompetitionEntriesOnCompetitions);
//        BrowserUtils.waitForClickablility(communityPage.viewFirstOnMyCompetitionEntriesOnCompetitions,15);
    }

    @Then("user should be able to see one of the competitions")
    public void user_should_be_able_to_see_one_of_the_competitions() {

        communityPage.viewFirstOnMyCompetitionEntriesOnCompetitions.click();
        BrowserUtils.wait(3);

    }


    @Then("user should be able to click judging center on competitions")
    public void user_should_be_able_to_click_judging_center_on_competitions() {

        communityPage.competitionsOnCommunity.click();
        BrowserUtils.wait(1);
        communityPage.judgingCenterOnCompetition.click();
        BrowserUtils.wait(5);

    }

    @Then("user should be able to see one of the judgin bucket")
    public void user_should_be_able_to_see_one_of_the_judgin_bucket() {

        communityPage.viewScoresOnJudginCenter.click();
        BrowserUtils.wait(5);
    }




}
