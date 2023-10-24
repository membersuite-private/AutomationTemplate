import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  SubscriptionPage from '../pos/subscriptionpage'
import  ShopPage from '../pos/shoppage'
import MyAccountPage from '../pos/myaccountpage'


describe('PPS',() => {
    beforeEach(() => {

        cy.visit('https://purplepps.users.purple.membersuite.com/')
        // LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin()
        HomePage.checkHomeNav(['Community', 'Events', 'Shop', 'Donations', 'Certifications'])


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
        HomePage.clickShop()
        HomePage.clickBrowseShop()
        ShopPage.clickPenny()
        // ShopPage.clickItem()
        ShopPage.clickAddToCart()
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('Penny',' $0.01 ')
        ShopPage.fillFormUsingPaylater()
        SubscriptionPage.thankyoupopupInvoice
        
        LoginPage.goToProfile()
        MyAccountPage.clickMyAccount()
        MyAccountPage.PayFirstInvoiceHalfValue()
        ShopPage.fillFormUsingExistingValuesInvoice()
        SubscriptionPage.thankyoupopupInvoice()
      });

      // it('In order to pay full value invoice', () =>{
      //   HomePage.clickShop()
      //   HomePage.clickSubscribetoaPublication()
      //   SubscriptionPage.checkPublicationPagePPS()
      //   SubscriptionPage.clickAddtoCartPPS()
      //   ShopPage.fillFormUsingPaylater()
      //   SubscriptionPage.thankyoupopup()
        
      //   LoginPage.goToProfile()
      //   MyAccountPage.clickMyAccount()
      //   MyAccountPage.clickMyInfo()
      //   MyAccountPage.clickMyAccount()
      //   MyAccountPage.PayFirstInvoiceFullValue()
      //   ShopPage.fillFormUsingExistingValuesInvoice()
      //   SubscriptionPage.thankyoupopupInvoice()
      // });



});
