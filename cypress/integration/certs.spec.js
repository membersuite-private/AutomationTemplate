import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CertificationsPage  from '../pos/certificationsPage'
import example from '../fixtures/example.json'


describe('Certifications', () => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickCertifications()
      });


    it('[PURPLE] In order to Report CEU Credits', () => {
        HomePage.clickReportCEUCredits()
        CertificationsPage.checkReportEditCEUCreditsPopUp()
        CertificationsPage.fillCEUCreditsForm()
        CertificationsPage.checkMyCEUCreditHistory()
    });


    it('[PURPLE] In order to Edit CEU Credits', () => {
        HomePage.clickViewMyCreditHistory()
        CertificationsPage.editCEUCredit()
    });

    it('[PURPLE] In order to Delete CEU Credits', () => {
        HomePage.clickViewMyCreditHistory()
        CertificationsPage.deleteCEUCredit()
    });

    it('[PURPLE] In order to Print CEU Credits', () => {
        HomePage.clickViewMyCreditHistory()
        CertificationsPage.printCEUCredit()
    });

    it('[PURPLE] In order to Download Transcripts Credits', () => {

        HomePage.clickViewMyCreditHistory()
        CertificationsPage.transcriptCEUCredit()
    });
  

});