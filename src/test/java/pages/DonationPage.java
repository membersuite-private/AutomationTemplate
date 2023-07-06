package pages;

import com.codeborne.selenide.SelenideDriver;
import com.codeborne.selenide.SelenideElement;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import utils.Driver;
import com.codeborne.selenide.SelenideElement;

import static com.codeborne.selenide.Selenide.$;

public class DonationPage{

    public SelenideElement donationsOnMain = $(By.xpath("(//*[contains(text(),'Donations')])[1]"));
    public SelenideElement makeDonation = $(By.xpath("//div[contains(text(),'Make a Donation')]"));
    public SelenideElement viewGivingHistory = $(By.xpath("//div[contains(text(),'View My Giving History')]"));
    public SelenideElement givingHistoryOnView = $(By.xpath("//h2[normalize-space()='My Giving History']"));
    public SelenideElement lastYearonView = $(By.xpath("//span[normalize-space()='Last Year']"));
    public SelenideElement totalOnView = $(By.xpath("//span[normalize-space()='Total']"));
    public SelenideElement giftOnView = $(By.xpath("(//*[contains(text(),'Gift#')])[1]"));
    public SelenideElement giftFundOnView = $(By.xpath("(//*[contains(text(),'Gift Fund')])[1]"));
    public SelenideElement giftAmountOnView = $(By.xpath("(//*[contains(text(),'Gift Amount')])[1]"));
    public SelenideElement giftDateOnView = $(By.xpath("(//*[contains(text(),'Gift Date')])[1]"));
    public SelenideElement typeOnView = $(By.xpath("(//*[contains(text(),'Type')])[1]"));
    public SelenideElement giftArrowOnView = $(By.xpath("//button[@aria-label='Change sorting for giftId']"));
    public SelenideElement giftFundArrowOnView = $(By.xpath("//button[@aria-label='Change sorting for giftFund']"));
    public SelenideElement giftAmountArrowOnView = $(By.xpath("//button[@aria-label='Change sorting for giftAmount']"));
    public SelenideElement giftDateArrowOnView = $(By.xpath("//button[@aria-label='Change sorting for giftDate']"));
    public SelenideElement giftTypeArrowOnView = $(By.xpath("//div[@class='mat-sort-header-stem ng-tns-c245-14']"));
    public SelenideElement openPledgesOnView = $(By.xpath("//h2[normalize-space()='My Open Pledges and Recurring Gifts']"));
    public SelenideElement funnyMoneyFundExample = $(By.xpath("//input[@type='radio']"));
    public SelenideElement fivedollarDonation = $(By.xpath("//div[contains(text(),'$11.00')]"));
    public SelenideElement streetOne = $(By.xpath("//input[@data-test='shipping-address-1']"));
    public SelenideElement streetTwo = $(By.xpath("//input[@data-test='shipping-address-2']"));
    public SelenideElement city = $(By.xpath("//input[@data-test='shipping-city']"));
    public SelenideElement state = $(By.xpath("//*[@data-test='shipping-state']"));
    public SelenideElement georgiaState = $(By.xpath("//span[normalize-space()='Georgia']"));
    public SelenideElement zipCode = $(By.xpath("//*[@data-test='shipping-zip-code']"));
    public SelenideElement country = $(By.xpath("//mat-select[@id='mat-select-5']//div[@class='mat-select-value']"));
    public SelenideElement creditCard = $(By.xpath("//*[@data-test='input-card-number']"));
    public SelenideElement nameOnCreditCard = $(By.xpath("//*[@data-test='input-holder-name']"));
    public SelenideElement expMonth = $(By.xpath("//*[@data-test='input-exp-month']"));
    public SelenideElement mayExpireMonth = $(By.xpath("//span[normalize-space()='05']"));
    public SelenideElement expYear = $(By.xpath("//*[@data-test='input-exp-year']"));
    public SelenideElement tweentysixExpireYear = $(By.xpath("//span[normalize-space()='26']"));
    public SelenideElement securityCode = $(By.xpath("//*[@data-test='input-sec-code']"));
    public SelenideElement continueOnDonation = $(By.xpath("//button[normalize-space()='Continue']"));
    public SelenideElement processDonation = $(By.xpath("//button[normalize-space()='Process Donation']"));
    public SelenideElement donationSuccessful = $(By.xpath("//*[normalize-space()='Donation Successful']"));
    public SelenideElement thankYouMessage = $(By.xpath("//div[@class='message ng-star-inserted']"));
    public SelenideElement closeButtonOnDonation = $(By.xpath("//button[normalize-space()='Close']"));

}
