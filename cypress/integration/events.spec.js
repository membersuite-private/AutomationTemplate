import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  EventsPage  from '../pos/eventspage'
import  Utils from '../support/utils'

describe('Events', () => {
    beforeEach(() => {
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin()
        HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
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