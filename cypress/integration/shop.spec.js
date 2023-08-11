import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import ShopPage from '../pos/shoppage'
import  Utils from '../support/utils'

// const page = new HomePage()
// const loginPage = new LoginPage()
// const careerCenterpage = new CareerCenterPage()

describe('Home Page loads when user opens application in browser',() => {
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
        ShopPage.checkPopUpCart()
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout()
        ShopPage.fillFormUsingExistingValues()
        ShopPage.checkThankYouPopUp()

      });

});
