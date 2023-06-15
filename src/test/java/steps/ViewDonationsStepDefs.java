package steps;

import pages.DonationPage;
import pages.MainPage;
import utils.BrowserUtils;
import utils.ConfigurationReader;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import org.junit.Assert;

public class ViewDonationsStepDefs {

    DonationPage donationPage=new DonationPage();

    @Then("user should be able to click view my giving history")
    public void user_should_be_able_to_click_view_my_giving_history() {
        BrowserUtils.wait(3);
        donationPage.donationsOnMain.click();
        BrowserUtils.wait(1);
        BrowserUtils.clickWithJS(donationPage.viewGivingHistory);
        BrowserUtils.wait(3);
    }

    @Then("user should be able to see giving history elements")
    public void user_should_be_able_to_see_giving_history_elements() {

//        BrowserUtils.waitForVisibility(donationPage.givingHistoryOnView,5);
        Assert.assertTrue(donationPage.givingHistoryOnView.getText().equals("My Giving History"));
        Assert.assertTrue(donationPage.lastYearonView.getText().equals("Last Year"));
        Assert.assertTrue(donationPage.totalOnView.getText().equals("Total"));
        Assert.assertTrue(donationPage.giftOnView.getText().equals("Gift#"));
//        System.out.println(donationPage.giftOnView.getText());
//        System.out.println(donationPage.giftFundOnView.getText());
//        System.out.println(donationPage.giftAmountOnView.getText());
//        System.out.println(donationPage.giftDateOnView.getText());
//        System.out.println(donationPage.typeOnView.getText());
//        System.out.println(donationPage.openPledgesOnView.getText());
        Assert.assertTrue(donationPage.giftFundOnView.getText().equals("Gift Fund"));
        Assert.assertTrue(donationPage.giftAmountOnView.getText().equals("Gift Amount"));
        Assert.assertTrue(donationPage.giftDateOnView.getText().equals("Gift Date"));
        Assert.assertTrue(donationPage.typeOnView.getText().equals("Type"));
        Assert.assertTrue(donationPage.openPledgesOnView.getText().equals("My Open Pledges and Recurring Gifts"));
    }

    @Then("user should be able to change sorting on giving history")
    public void user_should_be_able_to_change_sorting_on_giving_history() {

        BrowserUtils.wait(3);
        BrowserUtils.clickWithJS(donationPage.giftArrowOnView);
        BrowserUtils.wait(2);
        BrowserUtils.clickWithJS(donationPage.giftFundArrowOnView);
        BrowserUtils.wait(2);
        BrowserUtils.clickWithJS(donationPage.giftAmountArrowOnView);
        BrowserUtils.wait(2);
        BrowserUtils.clickWithJS(donationPage.giftDateArrowOnView);
        BrowserUtils.wait(3);


    }



}
