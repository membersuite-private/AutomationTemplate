import  LoginPage from '../pos/loginpage'
import  SignupPage  from '../pos/signuppage'
import MyAccountPage from '../pos/myaccountpage'
import  Utils from '../support/utils'



describe('FusionAuth', () => {
    it('[PURPLE][GREEN][PRODUCTION] user with 1+ assoc - is not being prompted when resetting password', () => {
        LoginPage.navHome()
        LoginPage.acceptCookies()
        LoginPage.clickSignup()
        const email = Utils.createMailWithSymbols()
        SignupPage.fillFirstPageForm(email+"@yopmail.com")
        SignupPage.fillCreateAccountForm()
        SignupPage.fillOrganizationFormWithOrganization()
        SignupPage.fillCommunicationPreferences()
        SignupPage.checkConfirmationPopUp(email)
        MyAccountPage.goToMyAccount()
        MyAccountPage.checkMyAccountPage(email+"@yopmail.com")
        MyAccountPage.changeInfo()
        MyAccountPage.changeEmail(email)
    });


  

});