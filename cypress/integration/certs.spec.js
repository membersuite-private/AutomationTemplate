import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CertificationsPage  from '../pos/certificationspage'
import  Utils from '../support/utils'


describe('Certifications', () => {
    beforeEach(() => {
        LoginPage.doLogin()
        HomePage.clickCertifications()
      });


    it('In order to Report CEU Credits', () => {
        HomePage.clickReportCEUCredits()
        CertificationsPage.checkReportEditCEUCreditsPopUp()
        CertificationsPage.fillCEUCreditsForm()
        CertificationsPage.checkMyCEUCreditHistory()
    });

  

});