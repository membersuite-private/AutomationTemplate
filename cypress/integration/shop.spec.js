import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import ShopPage from '../pos/shoppage'


describe('Shop',() => {
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

      it('In order to verify electronic check payment in Shop Cart', () => {
        HomePage.clickBrowseShop()
        ShopPage.checkBrowseShopPage()
        ShopPage.clickBluePay()
        ShopPage.checkBluepayPage()
        ShopPage.clickAddToCart()
        ShopPage.checkPopUpCart('Qty: 1',' (1 Item)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout(' $5.00 ')
        ShopPage.checkSummary(' $5.00  x  1 ',' $5.00 ',' $0.00 ')
        ShopPage.fillFormUsingExistingValues()
        ShopPage.checkThankYouPopUp()

      });

      it('In order to verify add two itens in Shop Cart', () => {
        HomePage.clickBrowseShop()
        ShopPage.checkBrowseShopPage()
        ShopPage.clickBluePay()
        ShopPage.checkBluepayPage()
        ShopPage.clickAddTwoItensToCart()
        ShopPage.checkPopUpCart('Qty: 2',' (2 Items)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout(' $10.00 ')
        ShopPage.checkSummary(' $5.00  x  2 ',' $10.00 ',' $0.00 ')
        ShopPage.fillFormUsingExistingValues()
        ShopPage.checkThankYouPopUp()
      });

});
