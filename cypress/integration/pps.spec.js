import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  SubscriptionPage from '../pos/subscriptionpage'
import  ShopPage from '../pos/shoppage'
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

      // it('In order to save an ACH payment Method', () => {
      //   LoginPage.goToProfile()
      //   MyAccountPage.checkMyAccountPage()
      //   MyAccountPage.clickMyAccount()
      //   MyAccountPage.AddnewmethodPaymentACH()

      // });

      // it('In order to save a credit cart', () => {
      //   LoginPage.goToProfile()
      //   MyAccountPage.checkMyAccountPage()
      //   MyAccountPage.clickMyAccount()
      //   MyAccountPage.AddnewmethodPaymentCreditCard()

      // });

      it('In order to pay partial value', () =>{
        HomePage.clickSubscribetoaPublication()
        SubscriptionPage.checkPublicationPage()
        SubscriptionPage.clickAddtoCart()
        ShopPage.fillFormUsingPaylater()
        SubscriptionPage.thankyoupopup()
        
        LoginPage.goToProfile()
        MyAccountPage.clickMyAccount()
        MyAccountPage.PayFirstInvoiceHalfValue()
        ShopPage.fillFormUsingExistingValuesInvoice()
        SubscriptionPage.thankyoupopupInvoice()
      });

      it('In order to pay full value invoice', () =>{
        HomePage.clickSubscribetoaPublication()
        SubscriptionPage.checkPublicationPage()
        SubscriptionPage.clickAddtoCart()
        ShopPage.fillFormUsingPaylater()
        SubscriptionPage.thankyoupopup()
        
        LoginPage.goToProfile()
        MyAccountPage.clickMyAccount()
        MyAccountPage.clickMyInfo()
        MyAccountPage.clickMyAccount()
        MyAccountPage.PayFirstInvoiceFullValue()
        ShopPage.fillFormUsingExistingValuesInvoice()
        SubscriptionPage.thankyoupopupInvoice()
      });



});
