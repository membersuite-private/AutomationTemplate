package pages;

import com.codeborne.selenide.SelenideElement;
import utils.Driver;
import static com.codeborne.selenide.Selenide.*;
import org.openqa.selenium.By;

public class CommunityPage{

    public SelenideElement communityOnMain = $(By.xpath("(//*[contains(text(),'Community')])[1]"));
    public SelenideElement committeesOnCommunity = $(By.xpath("(//*[contains(text(),'Committees')])[1]"));
    public SelenideElement directoryOnCommunity = $(By.xpath("(//*[contains(text(),'Directory')])[1]"));
    public SelenideElement competitionsOnCommunity = $(By.xpath("(//*[contains(text(),'Competitions')])[1]"));
    public SelenideElement discussionsOnCommunity = $(By.xpath("(//*[contains(text(),'Discussions')])[1]"));
    public SelenideElement careerCenterOnCommunity = $(By.xpath("(//*[contains(text(),'Career Center')])[1]"));
    public SelenideElement viewMyCommitteesOnCommittees = $(By.xpath("(//*[contains(text(),'View My Committees')])[1]"));
    public SelenideElement browseCommitteesOnCommittees = $(By.xpath("(//*[contains(text(),'Browse Committees')])[1]"));
    public SelenideElement browseAllCommittees = $(By.xpath("(//*[contains(text(),'Browse All Committees')])[1]"));
    public SelenideElement currentCommitteeMembershipOnCommittees = $(By.xpath("(//*[contains(text(),'Current Committee Membership')])[1]"));
    public SelenideElement closedcommittesOnCommittee = $(By.xpath("(//*[contains(text(),'Closed committee')])[1]"));
    public SelenideElement committeeTypesOnBrowseCommittees = $(By.xpath("(//*[contains(text(),'Committee Types')])[1]"));
    public SelenideElement typeBOnCommitteeTypes = $(By.xpath("(//*[(.='B')])[1]"));
    public SelenideElement committeeTwoOnBrowseAllCommittees = $(By.xpath("//a[(@data-test='committee-name')]"));
    public SelenideElement viewDiscussionBoardOnDiscussions = $(By.xpath("(//*[contains(text(),'View Discussion Board')])[1]"));
    public SelenideElement viewMyTopicSubscriptionsOnDiscussions = $(By.xpath("(//*[contains(text(),'View My Topic Subscriptions')])[1]"));
    public SelenideElement discussionBoardTextOnDiscussions = $(By.xpath("(//*[contains(text(),'Favorite hobby')])[1]"));
    public SelenideElement warningOnDiscussionBoard = $(By.xpath("(//*[contains(text(),'You may')])[1]"));
    public SelenideElement subscribeForumOneOnDiscussionBoard = $(By.xpath("(//*[contains(text(),'Subscribe')])[1]"));
    public SelenideElement unsubscribeForumOneOnDiscussionBoard = $(By.xpath("(//*[contains(text(),'Unsubscribe')])[1]"));
    public SelenideElement forumOneNotMembersOnDiscussionBoard = $(By.xpath("(//*[contains(text(),'Favorite hobby')])[1]"));
    public SelenideElement musicStreamingOnForumOne = $(By.xpath("//*[contains(text(),'122860 Test')]"));
    public SelenideElement oneoftheforumOnTopicSubscriptions = $(By.xpath("(//*[contains(text(),'What color is best?')])[1]"));
    public SelenideElement searchButtonOnCareerCenter = $(By.xpath("(//button[contains(text(),'Search')])[1]"));
    public SelenideElement ITAvailableItemsOnCareerCenterJobBoard = $(By.xpath("(//option[contains(text(),'IT')])[1]"));
    public SelenideElement firstArrowOnCategoriesOnCareerCenter = $(By.xpath("(//*[@class='btn btn-default col-md-offset-2 str vertical-spacing-5 sm-spacing col-md-8'])[1]"));
    public SelenideElement applyButtonOnCareerCenterJobBoard = $(By.xpath("(//*[contains(text(),'Apply')])[1]"));
    public SelenideElement employersOnCareerCenter = $(By.xpath("(//*[contains(text(),'Employers')])[1]"));
    public SelenideElement orgDotCom130ApplyJob = $(By.xpath("(//*[contains(text(),'130 pm')])[1]"));
    public SelenideElement applyNow1049OnCareerCenterJobPost = $(By.xpath("(//*[contains(text(),'Apply Now')])[1]"));
    public SelenideElement applyOnApplyNowOnCareerCenter = $(By.xpath("(//button[contains(text(),'Apply')])[1]"));
    public SelenideElement viewOpenCompetitionsOnCompetitions = $(By.xpath("(//*[contains(text(),'View Open Competitions')])[1]"));
    public SelenideElement viewMyCompetitionEntriesOnCompetitions = $(By.xpath("(//*[contains(text(),'View My Competition')])[1]"));
    public SelenideElement judgingCenterOnCompetition = $(By.xpath("(//*[contains(text(),'Judging Center')])[1]"));
    public SelenideElement competitionTypeOnBrowseCompetitions = $(By.xpath("(//*[contains(text(),'Competition Type')])[2]"));
    public SelenideElement competitionType1OnCompTypeOnBrowseCompetitions = $(By.xpath("(//*[contains(text(),' Competition Type 1 ')])[1]"));
    public SelenideElement fancyCompetitionOnBrowseCompetition = $(By.xpath("(//*[contains(text(),' Tum on at 10 competition ')])[1]"));
    public SelenideElement enterNowOnFancyCompetition = $(By.xpath("(//*[contains(text(),'Enter Now')])[1]"));
    public SelenideElement addCompetitionFee = $(By.xpath("(//*[contains(text(),'Add')])[1]"));
    public SelenideElement entryTypeOnEntryFee = $(By.xpath("(//*[contains(text(),'Entry Type')])[2]"));
    public SelenideElement entryType1OnEntryTypeEntryFee = $(By.xpath("(//*[contains(text(),' entry 5 ')])[1]"));
    public SelenideElement nextOnEntryFee = $(By.xpath("(//*[contains(text(),'Next')])[1]"));
    public SelenideElement nameOnEntryForm = $(By.xpath("//input[@ng-reflect-name='Name this Entry']"));
    public SelenideElement whatColorSocksOnEntry = $(By.xpath("//input[@id='mat-form-field-label-31']"));
    public SelenideElement enterTheAlphateOnEntryFee = $(By.xpath("//input[@id='mat-input-8']"));
    public SelenideElement saveAsDraftOnEntryFee = $(By.xpath("(//*[contains(text(),'Save As Draft')])[1]"));
    public SelenideElement goHomeOnEntryConfirm = $(By.xpath("(//*[contains(text(),'Go Home')])[1]"));
    public SelenideElement viewFirstOnMyCompetitionEntriesOnCompetitions = $(By.xpath("(//*[contains(text(),'Tum on at 10 competition')])[2]"));
    public SelenideElement viewScoresOnJudginCenter = $(By.xpath("(//*[contains(text(),'View Scores')])[1]"));
    public SelenideElement committeesMenu = $(By.xpath("(//*[contains(text(),'Committees')])[1]"));















//    public CommunityPage() {
//        //it's mandatory if you want to use @FindBy annotation
//        //this means LoginPage class
//        //Driver.get() return webdriver object
//        PageFactory.initElements(Driver.get(), this) = $(By.xpath());
//    }


    /**
     * reusable login method
     * just call this method to login
     * provide username and password as parameters
     *
     * @param username
      @param password
     */




}
