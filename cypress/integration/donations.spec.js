import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  DonationsPage  from '../pos/donationspage'

describe('Donations', () => {
    beforeEach(() => {
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin()
        HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
        HomePage.clickDonations()

      });


    it('In order to verify view Donations page', () => {
      HomePage.clickViewMyGivingDonations()
      DonationsPage.checkDonationsHistory()
    });

    it('In order to verify Making Donations', () => {
      HomePage.clickMakingDonations()
      DonationsPage.clickFundraisingProduct01()
      DonationsPage.fillDonationForm()
      DonationsPage.checkCheckoutPage()
      DonationsPage.donationSuccessfulPopUp()

    });




});
