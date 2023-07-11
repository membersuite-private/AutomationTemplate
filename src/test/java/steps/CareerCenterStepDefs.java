package steps;

import com.codeborne.selenide.Condition;
import pages.CommunityPage;
import utils.BrowserUtils;
import io.cucumber.java.en.Then;

import java.time.Duration;

public class CareerCenterStepDefs {

    CommunityPage communityPage=new CommunityPage();

    @Then("user should be able to click Career Center")
    public void user_should_be_able_to_click_Career_Center() {

        communityPage.careerCenterOnCommunity.click();
        BrowserUtils.wait(3);

    }

    @Then("user should be able to click on find a job")
    public void user_should_be_able_to_click_on_find_a_job() {

        communityPage.searchButtonOnCareerCenter.click();
        BrowserUtils.wait(2);
    }

    @Then("user should be able to select IT and apply for search")
    public void user_should_be_able_to_select_IT_and_apply_for_search() {
        communityPage.ITAvailableItemsOnCareerCenterJobBoard.click();
        communityPage.firstArrowOnCategoriesOnCareerCenter.click();
        BrowserUtils.clickWithJS(communityPage.applyButtonOnCareerCenterJobBoard);
        BrowserUtils.wait(5);
    }


    @Then("user should be able to click on Employers and search resumes on Employers")
    public void user_should_be_able_to_click_on_Employers_and_search_resumes_on_Employers() {
        communityPage.employersOnCareerCenter.click();
        communityPage.searchButtonOnCareerCenter.click();
    }

    @Then("user should be able to see Resume results")
    public void user_should_be_able_to_see_Resume_results() {

    }


    @Then("user should be able to apply one of the job post")
    public void user_should_be_able_to_apply_one_of_the_job_post() {
        communityPage.orgDotCom130ApplyJob.shouldBe(Condition.visible, Duration.ofSeconds(10)).click();
//        BrowserUtils.wait(5);
        communityPage.applyNow1049OnCareerCenterJobPost.shouldBe(Condition.visible, Duration.ofSeconds(10)).click();
//        BrowserUtils.wait(2);
        communityPage.applyOnApplyNowOnCareerCenter.shouldBe(Condition.visible, Duration.ofSeconds(10)).click();
    }


}
