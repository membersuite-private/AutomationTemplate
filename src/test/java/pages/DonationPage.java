package pages;

import utils.Driver;;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

public class DonationPage extends BasePage{

    @FindBy(xpath = "(//*[contains(text(),'Donations')])[1]")
    public WebElement donationsOnMain;

    @FindBy(xpath = "//div[contains(text(),'Make a Donation')]")
    public WebElement makeDonation;

    @FindBy(xpath = "//div[contains(text(),'View My Giving History')]")
    public WebElement viewGivingHistory;

    @FindBy(xpath = "//h2[normalize-space()='My Giving History']")
    public WebElement givingHistoryOnView;

    @FindBy(xpath = "//span[normalize-space()='Last Year']")
    public WebElement lastYearonView;

    @FindBy(xpath = "//span[normalize-space()='Total']")
    public WebElement totalOnView;

    @FindBy(xpath = "(//*[contains(text(),'Gift#')])[1]")
    public WebElement giftOnView;

    @FindBy(xpath = "(//*[contains(text(),'Gift Fund')])[1]")
    public WebElement giftFundOnView;

    @FindBy(xpath = "(//*[contains(text(),'Gift Amount')])[1]")
    public WebElement giftAmountOnView;

    @FindBy(xpath = "(//*[contains(text(),'Gift Date')])[1]")
    public WebElement giftDateOnView;

    @FindBy(xpath = "(//*[contains(text(),'Type')])[1]")
    public WebElement typeOnView;

    @FindBy(xpath = "//div[@class='mat-sort-header-stem ng-tns-c245-10']")
    public WebElement giftArrowOnView;

    @FindBy(xpath = "//div[@class='mat-sort-header-stem ng-tns-c245-11']")
    public WebElement giftFundArrowOnView;

    @FindBy(xpath = "//div[@class='mat-sort-header-stem ng-tns-c245-12']")
    public WebElement giftAmountArrowOnView;

    @FindBy(xpath = "//div[@class='mat-sort-header-stem ng-tns-c245-13']")
    public WebElement giftDateArrowOnView;

    @FindBy(xpath = "//div[@class='mat-sort-header-stem ng-tns-c245-14']")
    public WebElement giftTypeArrowOnView;

    @FindBy(xpath ="//h2[normalize-space()='My Open Pledges and Recurring Gifts']")
    public WebElement openPledgesOnView;

    @FindBy(xpath = "//label[@for='donation-radiobutton1-funnymoneyfund-input']//div[@class='mat-radio-container']")
    public WebElement funnyMoneyFundExample;

    @FindBy(xpath = "//div[contains(text(),'$5.00')]")
    public WebElement fivedollarDonation;

    @FindBy(xpath = "//input[@data-test='shipping-address-1']")
    public WebElement streetOne;

    @FindBy(xpath = "//input[@data-test='shipping-address-2']")
    public WebElement streetTwo;

    @FindBy(xpath = "//input[@data-test='shipping-city']")
    public WebElement city;

    @FindBy(xpath = "//*[@data-test='shipping-state']")
    public WebElement state;

    @FindBy(xpath = "//span[normalize-space()='Georgia']")
    public WebElement georgiaState;

    @FindBy(xpath = "//*[@data-test='shipping-zip-code']")
    public WebElement zipCode;

    @FindBy(xpath = "//mat-select[@id='mat-select-5']//div[@class='mat-select-value']")
    public WebElement country;

    @FindBy(xpath = "//*[@data-test='input-card-number']")
    public WebElement creditCard;

    @FindBy(xpath = "//*[@data-test='input-holder-name']")
    public WebElement nameOnCreditCard;

    @FindBy(xpath = "//*[@data-test='input-exp-month']")
    public WebElement expMonth;

    @FindBy(xpath = "//span[normalize-space()='05']")
    public WebElement mayExpireMonth;

    @FindBy(xpath = "//*[@data-test='input-exp-year']")
    public WebElement expYear;

    @FindBy(xpath = "//span[normalize-space()='26']")
    public WebElement tweentysixExpireYear;

    @FindBy(xpath = "//*[@data-test='input-sec-code']")
    public WebElement securityCode;

    @FindBy(xpath = "//button[normalize-space()='Continue']")
    public WebElement continueOnDonation;

    @FindBy(xpath = "//button[normalize-space()='Process Donation']")
    public WebElement processDonation;

    @FindBy(xpath = "//*[normalize-space()='Donation Successful']")
    public WebElement donationSuccessful;

    @FindBy(xpath = "//div[@class='message ng-star-inserted']")
    public WebElement thankYouMessage;

    @FindBy(xpath = "//button[normalize-space()='Close']")
    public WebElement closeButtonOnDonation;

    public DonationPage() {
        //it's mandatory if you want to use @FindBy annotation
        //this means LoginPage class
        //Driver.get() return webdriver object
        PageFactory.initElements(Driver.get(), this);
    }


    /**
     * reusable login method
     * just call this method to login
     * provide username and password as parameters
     *
     * @param username
      @param password
     */




}
