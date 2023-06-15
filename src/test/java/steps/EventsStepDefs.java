package steps;

import pages.EventsPage;
import pages.MainPage;
import utils.BrowserUtils;
import io.cucumber.java.en.Then;

public class EventsStepDefs {

    MainPage mainPage=new MainPage();
    EventsPage eventsPage= new EventsPage();
    @Then("user should be able to click events on main page")
    public void user_should_be_able_to_click_events_on_main_page() {

        BrowserUtils.wait(3);
        mainPage.eventsOnMainPage.click();
        BrowserUtils.wait(2);
    }

    @Then("user should be able to register two new individual")
    public void user_should_be_able_to_register_two_new_individual() {

    }


    @Then("user should be able to click my events on Events")
    public void user_should_be_able_to_click_my_events_on_Events() {
        eventsPage.myEventsOnEvents.click();
        BrowserUtils.wait(3);
    }

    @Then("user should be able to click my exhibits on Events")
    public void user_should_be_able_to_click_my_exhibits_on_Events() {
        eventsPage.myExhibitsOnEvents.click();
        BrowserUtils.wait(3);
    }




}
