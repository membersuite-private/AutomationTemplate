import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  EventsPage  from '../pos/eventspage'
import example from '../fixtures/example.json'

describe('Events', () => {
    beforeEach(() => {
        cy.on("uncaught:exception", (e, runnable) => {
            console.log("error", e);
            console.log("runnable", runnable);
            console.log("error", e.message);
            return false;
            });
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickEvents()
      });

    it('In order to verify my Event Registrations', () => {
        EventsPage.checkEventsPage()
        EventsPage.clickOnGrpEvent()
        EventsPage.checkEventDetails()
        EventsPage.clickRegister()

    })

    it('In order to verify my Exhibits', () => {
        // HomePage.clickEvents()
        HomePage.clickMyExhibits()

    })

});