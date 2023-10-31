import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  EventsPage  from '../pos/eventspage'
import example from '../fixtures/example.json'

describe('Events', () => {
    beforeEach(() => {

      });

    it('[PURPLE][GREEN][PRODUCTION] In order to verify my Event Registrations', () => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickEvents()
        EventsPage.checkEventsPage()
        EventsPage.clickOnGrpEvent()
        EventsPage.checkEventDetails()
        EventsPage.clickRegister()

    })

    it('[PURPLE][GREEN][PRODUCTION] In order to verify my Exhibits', () => {
        // HomePage.clickEvents()
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickEvents()
        HomePage.clickMyExhibits()

    })

    it('[PURPLE][GREEN][PRODUCTION] In order to verify my Event Registrations as a Organization', () => {
        // HomePage.clickEvents()
        LoginPage.doLogin(example.orgUser.email,example.orgUser.passwd)
        HomePage.changeToOrg()
        EventsPage.checkEventsPage()
        EventsPage.clickOnGrpEvent()
        EventsPage.checkEventDetails()
        EventsPage.clickRegister()

    })

});