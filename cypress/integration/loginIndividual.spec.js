import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  Utils from '../support/utils'


describe('Home Page loads when user opens application in browser', () => {

  const credentials = {
      realuser: {
          email: 'testautomation@yoip.com',
          passwd: 'Password1!',
      },
  }

    beforeEach(() => {

        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()


      });


    it('In order to verify Login Functionality', () => {
      LoginPage.doLogin(credentials.realuser)
      HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
    });

    it('In order to verify invalid password', () => {

    });

    it('In order to verify invalid username', () => {

    });

    it('In order to verify invalid username and password', () => {

    });

    it('In order to change password from multiple Associations', () => {

    });






});
