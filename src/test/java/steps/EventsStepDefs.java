package steps;

import com.codeborne.selenide.Condition;
import io.cucumber.java.ro.Si;
import pages.EventsPage;
import pages.MainPage;
import pages.SignupPage;
import utils.BrowserUtils;
import io.cucumber.java.en.Then;

import java.time.Duration;

public class EventsStepDefs {

    MainPage mainPage=new MainPage();
    EventsPage eventsPage= new EventsPage();
    SignupPage signupPage = new SignupPage();
    @Then("user should be able to click events on main page")
    public void user_should_be_able_to_click_events_on_main_page() {

        BrowserUtils.wait(3);
        mainPage.eventsOnMainPage.shouldBe(Condition.visible, Duration.ofSeconds(10)).click();
//        mainPage.eventsOnMainPage.click();
        BrowserUtils.wait(2);
    }

    @Then("user should be able to register two new individual")
    public void user_should_be_able_to_register_two_new_individual() {
//        eventsPage.firstEvent.shouldBe(Condition.visible,Duration.ofSeconds(10));
        BrowserUtils.clickWithJS(eventsPage.browseEvents);
        BrowserUtils.wait(3);
        BrowserUtils.clickWithJS(eventsPage.firstEvent);
//        eventsPage.clickRegisterEvent.shouldBe(Condition.visible,Duration.ofSeconds(10));
        BrowserUtils.clickWithJS(eventsPage.clickRegisterEvent);
        BrowserUtils.wait(3);
        eventsPage.registerFreeEvent.shouldBe(Condition.visible,Duration.ofSeconds(10)).click();
        signupPage.nextButton.shouldBe(Condition.visible, Duration.ofSeconds(10));
    }


    @Then("user should be able to click my events on Events")
    public void user_should_be_able_to_click_my_events_on_Events() {
//        eventsPage.myEventsOnEvents.click();
        BrowserUtils.clickWithJS(eventsPage.myEventsOnEvents);
        BrowserUtils.wait(3);
    }

    @Then("user should be able to click my exhibits on Events")
    public void user_should_be_able_to_click_my_exhibits_on_Events() {
        BrowserUtils.clickWithJS(eventsPage.myExhibitsOnEvents);
        BrowserUtils.wait(3);
    }




}
