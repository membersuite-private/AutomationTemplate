import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  SubscriptionPage  from '../pos/subscriptionpage'
import ShopPage from '../pos/shoppage'
import example from '../fixtures/example.json'

describe('Subscriptions', () => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickShop()

      });


    it('[PURPLE][GREEN][PRODUCTION] In order to verify pay later Subscribe Publication', () => {
      HomePage.clickSubscribetoaPublication()
      SubscriptionPage.checkPublicationPage()
      SubscriptionPage.clickAddtoCart()
      ShopPage.fillFormUsingPaylater()
      SubscriptionPage.thankyoupopup()
    });

    it('[PURPLE][GREEN] In order to verify electronic check payment Subscribe Publication', () => {
      HomePage.clickSubscribetoaPublication()
      SubscriptionPage.checkPublicationPage()
      SubscriptionPage.clickAddtoCart()
      ShopPage.fillFormUsingExistingValues()
      SubscriptionPage.thankyoupopup()
    });

    it('[PURPLE][GREEN][PRODUCTION] In order to verify view my subscriptions', () => {
      HomePage.clickViewSubscription()
      SubscriptionPage.checkMySubscription()
    });




});
