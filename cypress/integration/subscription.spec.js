import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  SubscriptionPage  from '../pos/subscriptionpage'
import ShopPage from '../pos/shoppage'
import  Utils from '../support/utils'

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
