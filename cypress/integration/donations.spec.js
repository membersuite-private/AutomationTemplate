import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  DonationsPage  from '../pos/donationspage'
import  Utils from '../support/utils'

// const page = new HomePage()
// const loginPage = new LoginPage()
// const careerCenterpage = new CareerCenterPage()

describe('Home Page loads when user opens application in browser', () => {
    beforeEach(() => {
        const credentials = {
            realuser: {
                email: 'testautomation@yoip.com',
                passwd: 'Password1!',
            },
        }
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin(credentials.realuser)
        HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
        HomePage.clickDonations()

      });


    // it('In order to verify view Donations page', () => {
    //   HomePage.clickViewMyGivingDonations()
    //   DonationsPage.checkDonationsHistory()
    // });

    it('In order to verify Making Donations', () => {
      HomePage.clickMakingDonations()
      DonationsPage.clickFundraisingProduct01()

    });




});
