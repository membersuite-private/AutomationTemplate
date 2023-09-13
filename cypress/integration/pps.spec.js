import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import MyAccountPage from '../pos/myaccountpage'


describe('PPS',() => {
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


      });

      it('In order to save an ACH payment Method', () => {
        LoginPage.goToProfile()
        MyAccountPage.checkMyAccountPage()
        MyAccountPage.clickMyAccount()
        MyAccountPage.AddnewmethodPaymentACH()

      });

      it('In order to save a credit cart', () => {
        LoginPage.goToProfile()
        MyAccountPage.checkMyAccountPage()
        MyAccountPage.clickMyAccount()
        MyAccountPage.AddnewmethodPaymentCreditCard()

      });



});
