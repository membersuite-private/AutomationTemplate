import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  EventsPage  from '../pos/eventspage'
import example from '../fixtures/example.json'

describe('Events', () => {
    beforeEach(() => {
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