import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import ShopPage from '../pos/shoppage'
import example from '../fixtures/example.json'
import Utils from '../support/utils'


describe('Shop',() => {
    // beforeEach(() => {
    //     LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
    //     Utils.shoppingInitial()
    //   });

      it('In order to verify electronic check payment in Shop Cart', () => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        Utils.shoppingInitial()
        ShopPage.clickAddToCart()
        ShopPage.checkPopUpCart('Qty: 1',' (1 Item)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('BluePay',' $5.00 ')
        ShopPage.checkSummary(' $5.00  x  1 ',' $5.00 ',' $0.00 ')
        ShopPage.fillFormUsingExistingValues()
        ShopPage.checkThankYouPopUp('testautomation@yoip.com')

      });

      it('In order to verify add two itens in Shop Cart', () => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        Utils.shoppingInitial()
        ShopPage.clickAddTwoItensToCart()
        ShopPage.checkPopUpCart('Qty: 2',' (2 Items)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('BluePay',' $10.00 ')
        ShopPage.checkSummary(' $5.00  x  2 ',' $10.00 ',' $0.00 ')
        ShopPage.fillFormUsingExistingValues()
        ShopPage.checkThankYouPopUp('testautomation@yoip.com')
      });

      it('In order to pay with a card with invalid expiration date', () =>{
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        Utils.shoppingInitial()
        ShopPage.clickAddToCart()
        ShopPage.checkPopUpCart('Qty: 1',' (1 Item)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('BluePay',' $5.00 ')
        ShopPage.checkSummary(' $5.00  x  1 ',' $5.00 ',' $0.00 ')
        ShopPage.fillFormUsingInvalidExpiration()
        ShopPage.checkPopUpFailedProcessing()
      });

      it('In order to pay with a card with invalid card number', () =>{
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        Utils.shoppingInitial()
        ShopPage.clickAddToCart()
        ShopPage.checkPopUpCart('Qty: 1',' (1 Item)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('BluePay',' $5.00 ')
        ShopPage.checkSummary(' $5.00  x  1 ',' $5.00 ',' $0.00 ')
        ShopPage.fillFormUsingInvalidCard()
        ShopPage.checkInvalidCardNumber()
      });

      it('In order to use a valid discount code', () =>{
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        Utils.shoppingInitial()
        ShopPage.clickAddToCart()
        ShopPage.checkPopUpCart('Qty: 1',' (1 Item)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('BluePay',' $5.00 ')
        ShopPage.checkSummary(' $5.00  x  1 ',' $5.00 ',' $0.00 ')
        ShopPage.fillFormUsingDiscountCode()
        ShopPage.checkThankYouPopUp('testautomation@yoip.com')
      });

      it('In order to pay using ACH', () => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        Utils.shoppingInitial()
        ShopPage.clickAddToCart()
        ShopPage.checkPopUpCart('Qty: 1',' (1 Item)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('BluePay',' $5.00 ')
        ShopPage.checkSummary(' $5.00  x  1 ',' $5.00 ',' $0.00 ')
        ShopPage.fillFormUsingNewPaymentACH()
        ShopPage.checkThankYouPopUp('testautomation@yoip.com')

        //DELETE SAVED ACH METHOD
        HomePage.clickShop()
        HomePage.clickBrowseShop()
        ShopPage.checkBrowseShopPage()
        ShopPage.clickBluePay()
        ShopPage.checkBluepayPage()
        ShopPage.clickAddToCart()
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('BluePay',' $5.00 ')
        ShopPage.deleteSavedACH()
      });

      it('In order to add cart with Org profile', () =>{
        LoginPage.doLogin(example.orgUser.email,example.orgUser.passwd)
        HomePage.changeToOrg()
        Utils.shoppingInitial()
        ShopPage.clickAddToCart()
        ShopPage.checkPopUpCart('Qty: 1',' (1 Item)')
        ShopPage.clickContinueToCart()
        ShopPage.clickCheckout('BluePay',' $5.00 ')
        ShopPage.checkSummary(' $5.00  x  1 ',' $5.00 ',' $0.00 ')
        ShopPage.fillFormUsingExistingValues()
        ShopPage.checkThankYouPopUp('testautomation_org@yoip.com')
      });

});
