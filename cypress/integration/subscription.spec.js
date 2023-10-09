import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  SubscriptionPage  from '../pos/subscriptionpage'
import ShopPage from '../pos/shoppage'

describe('Subscriptions', () => {
    beforeEach(() => {
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin()
        HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
        HomePage.clickShop()

      });


    it('In order to verify pay later Subscribe Publication', () => {
      HomePage.clickSubscribetoaPublication()
      SubscriptionPage.checkPublicationPage()
      SubscriptionPage.clickAddtoCart()
      ShopPage.fillFormUsingPaylater()
      SubscriptionPage.thankyoupopup()
    });

    it('In order to verify electronic check payment Subscribe Publication', () => {
      HomePage.clickSubscribetoaPublication()
      SubscriptionPage.checkPublicationPage()
      SubscriptionPage.clickAddtoCart()
      ShopPage.fillFormUsingExistingValues()
      SubscriptionPage.thankyoupopup()
    });

    it('In order to verify view my subscriptions', () => {
      HomePage.clickViewSubscription()
      SubscriptionPage.checkMySubscription()
    });




});
