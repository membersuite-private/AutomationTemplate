import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import example from '../fixtures/example.json'


describe('Login Individual', () => {

    it('In order to verify Login Functionality', () => {
      LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
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
