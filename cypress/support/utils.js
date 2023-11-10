import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import ShopPage from '../pos/shoppage'

class Utils {
    wait(timer){
        cy.wait(timer)
    }

    randomNumber(){
      return Math.random()
    }

    createMail(){
      const currentDate = new Date();

      // Extract various components of the date and time
      const year = currentDate.getFullYear();      // e.g., 2023
      const month = currentDate.getMonth();        // 0 (January) to 11 (December)
      const day = currentDate.getDate();           // e.g., 2
      const hours = currentDate.getHours();        // e.g., 14 (24-hour format)
      const minutes = currentDate.getMinutes();    // e.g., 30
      const seconds = currentDate.getSeconds();    // e.g., 45

      const mail = month+day+year+hours+minutes;
      const random = this.randomNumber();
      return mail+random+"@yopmail.com"
    }

    shoppingInitial(){
      ShopPage.checkShoppingCart()
      HomePage.clickShop()
      HomePage.clickBrowseShop()
      ShopPage.checkBrowseShopPage()
      ShopPage.clickBluePay()
      ShopPage.checkBluepayPage()
    }
}

export default new Utils
