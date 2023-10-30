import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CertificationsPage  from '../pos/certificationspage'
import  Utils from '../support/utils'
import example from '../fixtures/example.json'


describe('Certifications', () => {
    beforeEach(() => {
        cy.on("uncaught:exception", (e, runnable) => {
            console.log("error", e);
            console.log("runnable", runnable);
            console.log("error", e.message);
            return false;
            });
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickCertifications()
      });


    it('In order to Report CEU Credits', () => {
        HomePage.clickReportCEUCredits()
        CertificationsPage.checkReportEditCEUCreditsPopUp()
        CertificationsPage.fillCEUCreditsForm()
        CertificationsPage.checkMyCEUCreditHistory()
    });


    it('In order to Edit CEU Credits', () => {
        HomePage.clickReportCEUCredits()
        CertificationsPage.checkReportEditCEUCreditsPopUp()
        CertificationsPage.fillCEUCreditsForm()
        CertificationsPage.checkMyCEUCreditHistory()
        CertificationsPage.editCEUCredit()
    });

    it('In order to Delete CEU Credits', () => {
        HomePage.clickReportCEUCredits()
        CertificationsPage.checkReportEditCEUCreditsPopUp()
        CertificationsPage.fillCEUCreditsForm()
        CertificationsPage.checkMyCEUCreditHistory()
        CertificationsPage.deleteCEUCredit()
    });

    it('In order to Print CEU Credits', () => {
        HomePage.clickReportCEUCredits()
        CertificationsPage.checkReportEditCEUCreditsPopUp()
        CertificationsPage.fillCEUCreditsForm()
        CertificationsPage.checkMyCEUCreditHistory()
        CertificationsPage.printCEUCredit()
    });

    it('In order to Download Transcripts Credits', () => {
        HomePage.clickReportCEUCredits()
        CertificationsPage.checkReportEditCEUCreditsPopUp()
        CertificationsPage.fillCEUCreditsForm()
        CertificationsPage.checkMyCEUCreditHistory()
        CertificationsPage.transcriptCEUCredit()
    });
  

});