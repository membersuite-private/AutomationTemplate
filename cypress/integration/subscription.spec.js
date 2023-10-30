import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  SubscriptionPage  from '../pos/subscriptionpage'
import ShopPage from '../pos/shoppage'
import example from '../fixtures/example.json'

describe('Subscriptions', () => {
    beforeEach(() => {
      cy.on("uncaught:exception", (e, runnable) => {
        console.log("error", e);
        console.log("runnable", runnable);
        console.log("error", e.message);
        return false;
        });
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
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
