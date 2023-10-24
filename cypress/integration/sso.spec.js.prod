import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  SignupPage  from '../pos/signuppage'
import  SS0Page  from '../pos/ssopage'
import  Utils from '../support/utils'


describe('SSO', () => {
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
        SS0Page.visitSSOPage()
        SS0Page.fillform(email)
        SS0Page.checkValues(email)

    });

});