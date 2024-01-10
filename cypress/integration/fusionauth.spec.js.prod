import  LoginPage from '../pos/loginpage'
import  SignupPage  from '../pos/signuppage'
import MyAccountPage from '../pos/myaccountpage'
import HomePage from '../pos/homepage'
import  Utils from '../support/utils'



describe('FusionAuth', () => {
    it.skip('[PURPLE][GREEN][PRODUCTION] User is able to join with symbols in their email address, but are unable to save when they update their profile', () => {
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
        MyAccountPage.clickYesButton()

        //VALIDATING
        LoginPage.navHome()
        LoginPage.clickLogout()
        LoginPage.navHome()
        LoginPage.checkInvalidUsername(email+'@yopmail.com')

        LoginPage.fillEmail(email+'+-'+'@yopmail.com');
        LoginPage.fillPassword('Password1!');
        LoginPage.submitLoginForm()
        HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])

    });

    it.skip('[PURPLE][GREEN][PRODUCTION] User with 1+ assoc - is not being prompted when resetting password', () =>{
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

    it.skip('[PURPLE][GREEN][PRODUCTION] user with 1+ assoc - changes email to separate the 2 assoc issues - part 1', () =>{
        const email = Utils.createMailWithSymbols()
        const environment = 'PURPLE'

        LoginPage.navHome()
        LoginPage.acceptCookies()
        LoginPage.clickSignup()
        SignupPage.fillFirstPageForm(email+"@yopmail.com")
        SignupPage.fillCreateAccountForm()
        SignupPage.fillOrganizationFormWithoutOrganization()
        SignupPage.fillCommunicationPreferences()
        SignupPage.checkConfirmationPopUp(email)

        //SECOND ASSOC
        Otherassocpage.visitDemonstration(environment)
        Otherassocpage.joinDemonstration(environment)
        LoginPage.acceptCookies()
        SignupPage.fillFirstPageForm(email+"@yopmail.com")
        Otherassocpage.checkMessage()
        Otherassocpage.fillCreateAccountForm(environment)
        Otherassocpage.fillOrganizationFormWithoutOrganization(environment)
        SignupPage.fillCommunicationPreferences()
        SignupPage.checkConfirmationPopUp(email)

        //CHANGE EMAIL
        LoginPage.navHome()
        LoginPage.navHere()
        LoginPage.clickLogin()
        MyAccountPage.goToMyAccount()
        MyAccountPage.checkMyAccountPage(email+"@yopmail.com")
        MyAccountPage.changeInfo()
        Otherassocpage.changeEmail(email)
        Otherassocpage.emailChangeConfirmation(environment)
    });

    it.skip('[PURPLE][GREEN][PRODUCTION] FUSION AUTH PAGE', () => {
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

        cy.visit('growthzone-dev.fusionauth.io/admin')
        cy.get('button').click()
        cy.wait(15000)
        cy.visit('https://growthzone-dev.fusionauth.io/admin/user/')
        cy.get('input').type(email)
        cy.get('button').contains('Search').click()
        cy.wait(15000)
    });

    it('[PURPLE][GREEN][PRODUCTION] User is not able to change their email to an email that already exists within that association', () => {
        LoginPage.navHome()
        LoginPage.acceptCookies()
        LoginPage.clickSignup()
        const email = Utils.createMail()
        SignupPage.fillFirstPageForm(email)
        SignupPage.fillCreateAccountForm()
        SignupPage.fillOrganizationFormWithOrganization()
        SignupPage.fillCommunicationPreferences()
        SignupPage.checkConfirmationPopUp(email)
        MyAccountPage.goToMyAccount()
        MyAccountPage.checkMyAccountPage(email)
        MyAccountPage.changeInfo()
        MyAccountPage.changeEmail('testautomation@yoip.com')
        MyAccountPage.checkMessageErrorEmailUsed()
    });

});
