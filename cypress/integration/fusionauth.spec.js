import  LoginPage from '../pos/loginpage'
import  SignupPage  from '../pos/signuppage'
import MyAccountPage from '../pos/myaccountpage'
import Otherassocpage from '../pos/otherassocpage'
import  Utils from '../support/utils'



describe('FusionAuth', () => {
    it('[PURPLE][GREEN][PRODUCTION] User is able to join with symbols in their email address, but are unable to save when they update their profile', () => {
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

    it('[PURPLE][GREEN][PRODUCTION] user with 1+ assoc - changes email to separate the 2 assoc issues - part 1', () =>{
        const email = Utils.createMail()
        const environment = 'PURPLE'

        LoginPage.navHome()
        LoginPage.acceptCookies()
        LoginPage.clickSignup()
        SignupPage.fillFirstPageForm(email)
        SignupPage.fillCreateAccountForm()
        SignupPage.fillOrganizationFormWithoutOrganization()
        SignupPage.fillCommunicationPreferences()
        SignupPage.checkConfirmationPopUp(email)

        //SECOND ASSOC
        Otherassocpage.visitDemonstration(environment)
        Otherassocpage.joinDemonstration(environment)
        LoginPage.acceptCookies()
        SignupPage.fillFirstPageForm(email)
        Otherassocpage.checkMessage()
        Otherassocpage.fillCreateAccountForm(environment)
        Otherassocpage.fillOrganizationFormWithoutOrganization(environment)
        SignupPage.fillCommunicationPreferences()
        SignupPage.checkConfirmationPopUp(email)

        //RESET PASSWORD
        LoginPage.navHome()
        LoginPage.navHere()
        LoginPage.clickLogin()
        Otherassocpage.changePassword(environment)
    });


});