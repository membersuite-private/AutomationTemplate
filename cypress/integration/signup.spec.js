import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  SignupPage  from '../pos/signuppage'
import  Utils from '../support/utils'

describe('Sign Up', () => {
    beforeEach(() => {
        LoginPage.navHome()
        LoginPage.acceptCookies()
        LoginPage.clickSignup()

      });

      it('Sign up new user  not affiliated to a Organization', () => {
          const email = Utils.createMail()
          SignupPage.fillFirstPageForm(email)
          SignupPage.fillCreateAccountForm()
          SignupPage.fillOrganizationFormWithoutOrganization()
          SignupPage.fillCommunicationPreferences()
          SignupPage.checkConfirmationPopUp()

      });

      it('Sign up without First Name', () => {
          const email = Utils.createMail()
          SignupPage.fillCreateAccountWithoutFirstName(email)

      });

      it('Sign up without Last Name', () => {
          const email = Utils.createMail()
          SignupPage.fillCreateAccountWithoutLastName(email)

      });

      it('Sign up without Email', () => {
          const email = Utils.createMail()
          SignupPage.fillCreateAccountWithoutEmail(email)

      });

      it('Sign up new user affiliated to a Organization', () => {
          const email = Utils.createMail()
          SignupPage.fillFirstPageForm(email)
          SignupPage.fillCreateAccountForm()
          SignupPage.fillOrganizationFormWithOrganization()
          SignupPage.fillCommunicationPreferences()
          SignupPage.checkConfirmationPopUp()

      });


});
