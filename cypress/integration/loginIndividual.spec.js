import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  Utils from '../support/utils'


describe('Login Individual', () => {

  const credentials = {
      realuser: {
          email: 'testautomation@yoip.com',
          passwd: 'Password1!',
      },
  }


    it('In order to verify Login Functionality', () => {
      LoginPage.doLogin()
      // HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
    });

    it('In order to verify invalid password', () => {
      LoginPage.checkInvalidPassword()
    });

    it('In order to verify invalid username', () => {
      LoginPage.checkInvalidUsername()
    });

    it('In order to verify invalid username and password', () => {
      LoginPage.checkInvalidUsernamePassword()
    });

    it('In order to change password from multiple Associations', () => {

    });






});
