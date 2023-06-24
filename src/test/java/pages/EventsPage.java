package pages;

import com.codeborne.selenide.Selenide;
import com.codeborne.selenide.SelenideDriver;
import com.codeborne.selenide.SelenideElement;
import com.codeborne.selenide.WebDriverRunner;
import com.codeborne.selenide.impl.SelenidePageFactory;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import utils.Driver;;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

import static com.codeborne.selenide.Selenide.$;

public class EventsPage{

//    @FindBy(xpath = "(//*[contains(text(),'Donations')])[1]")
//    public WebElement donationsOnMain;
//
//    @FindBy(xpath = "(//div[normalize-space()='Browse Events'])[1]")
//    public WebElement browseEventsOnEvents;
//
//    @FindBy(xpath = "(//div[normalize-space()='My Events'])[1]")
    public SelenideElement myEventsOnEvents = $(By.xpath("(//div[.=' My Events '])[2]"));
    public SelenideElement browseEvents = $(By.xpath("(//div[.=' Browse Events '])[2]"));
    public SelenideElement myExhibitsOnEvents = $(By.xpath("(//div[.=' My Exhibits '])[2]"));
//
//    @FindBy(xpath = "(//div[normalize-space()='My Exhibits'])[1]")
//    public WebElement myExhibitsOnEvents;
//
//    @FindBy(xpath = "(//div[normalize-space()='Members Only link'])[1]")
//    public WebElement membersOnlyLinkOnEvents;
//
//    @FindBy(xpath = "//div[@data-test='event-name-6']")
//    public WebElement type1028EventOnBrowseEvents;
//
//    @FindBy(xpath = "(//div[normalize-space()='Register'])[1]")
//    public WebElement registerOnEvent;
//
//    @FindBy(xpath = "(//div[normalize-space()='Register a Group'])[1]")
//    public WebElement groupRegisterOnEventsPage;
//
//    @FindBy(xpath = "(//*[normalize-space()='Register new contact'])[1]")
//    public WebElement registerNewContactOnEvents;
//
//    @FindBy(xpath = "//input[@id='add-attendees-new-contact-email']")
//    public WebElement emailAddressOnNewContact;
//
//    @FindBy(xpath = "//input[@id='add-attendees-new-contact-last-name']")
//    public WebElement lastNameOnNewContact;
//
//    @FindBy(xpath = "//input[@id='add-attendees-new-contact-first-name']")
//    public WebElement firstNameOnNewContact;
//
//    @FindBy(xpath = "//*[@id='add-attendees-new-contact-role']")
//    public WebElement roleChoiceOnNewContact;
//
//    @FindBy(xpath = "//*[@id='add-attendees-add-attendees-new-contact-role-option-PrimaryContacts']")
//    public WebElement primaryContactsOnNewContact;
//
//    @FindBy(xpath = "//*[@id='add-attendees-new-contact-register-button']")
//    public WebElement registerNewContactButton;
//
//    @FindBy(xpath = "(//*[normalize-space()='Next'])[1]")
//    public WebElement nextButtonOnNewContact;
//
//    @FindBy(xpath = "//*[@id='add-attendees-search-attendees-control']")
//    public WebElement searchSpaceOnEvents;
//
//    @FindBy(xpath = "//*[@id='add-attendees-search-attendees-button']")
//    public WebElement searchButtonOnEvents;
//
//    @FindBy(xpath = "//*[@id='add-attendees-contact-option-eb12a7be-0013-c561-4cde-0b438b839378-name']")
//    public WebElement ricoOnSearchOnEvents;
//
//    @FindBy(xpath = "//*[@id='add-attendees-contact-option-eb12a7be-0013-cf5e-76c8-0b438b837f5a-name']")
//    public WebElement omerOnSearchOnEvents;
//
//    @FindBy(xpath = "//*[@id='footer-b81bac0a-2757-4356-a4b8-61b6f0fac3cd']")
//    public WebElement nextOnEventsafterAttendees;
//
//    @FindBy(xpath = "//*[@id='package-selection-attendee-eb12a7be-0013-c561-4cde-0b438b839378-for-eb12a7be-007e-c027-d848-12464cc59fd2-select-button']")
//    public WebElement regfee3forRico;
//
//    @FindBy(xpath = "//*[@id='package-selection-attendee-eb12a7be-0013-cf5e-76c8-0b438b837f5a-for-eb12a7be-007e-c027-d848-12464cc59fd2-select-button']")
//    public WebElement regfee3forOmer;
//
//    @FindBy(xpath = "//*[@id='mat-expansion-panel-header-2']")
//    public WebElement omersPanelOpening;
//
//    @FindBy(xpath = "//*[@id='mat-input-1']")
//    public WebElement ageforRico;
//
//    @FindBy(xpath = "//*[@id='mat-input-2']")
//    public WebElement ageforOmer;
//
//    @FindBy(xpath = "(//*[contains(text(),'Add bank')])[1]")
//    public WebElement addBankAccountOnCheckout;
//
//    @FindBy(xpath = "//*[@id='mat-input-7']")
//    public WebElement bankRoutingNumberOnCheckOut;
//
//    @FindBy(xpath = "//*[@id='mat-input-8']")
//    public WebElement checkingAccountNumberOnCheckOut;
//
//    @FindBy(xpath = "(//*[contains(text(),'Save')])[1]")
//    public WebElement saveBankAccountOnEvents;

    public SelenideElement firstEvent = $(By.xpath("(//div[@class='event-name'])[1]"));
    public SelenideElement clickRegisterEvent = $(By.xpath("(//span[.='Register'])[1]"));
    public SelenideElement registerFreeEvent = $(By.xpath("//button[@data-test='package-select-button-0']"));




    public EventsPage() {
        //it's mandatory if you want to use @FindBy annotation
        //this means LoginPage class
//        Driver driver = Selenide.webdriver().driver().getWebDriver();
//        PageFactory.initElements(Selenium..get, this);
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
