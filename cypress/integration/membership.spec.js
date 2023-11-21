import  ShopPage  from '../pos/shoppage'
import  LoginPage from '../pos/loginpage'
import  CertificationsPage  from '../pos/certificationspage'
import  Utils from '../support/utils'
import example from '../fixtures/example.json'


describe('Membership', () => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        
      });


    it('[PURPLE][GREEN] In order to Report CEU Credits', () => {
        LoginPage.goToMembershipRegistration()
        ShopPage.fillFormUsingExistingValues()
        ShopPage.checkThankYouPopUp('testautomation@yoip.com')
    });
  

});