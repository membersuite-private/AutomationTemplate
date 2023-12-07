import HomePage from '../pos/homePage';
import  LoginPage from '../pos/loginpage'
import  CertificationsPage  from '../pos/certificationspage'
import example from '../fixtures/example.json'


describe('Certifications', () => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickCertifications()
      });


    it('[PURPLE][GREEN] In order to Report CEU Credits', () => {
        HomePage.clickReportCEUCredits()
        CertificationsPage.checkReportEditCEUCreditsPopUp()
        CertificationsPage.fillCEUCreditsForm()
        CertificationsPage.checkMyCEUCreditHistory()
    });


    it('[PURPLE][GREEN] In order to Edit CEU Credits', () => {
        HomePage.clickViewMyCreditHistory()
        CertificationsPage.editCEUCredit()
    });

    it('[PURPLE][GREEN] In order to Delete CEU Credits', () => {
        HomePage.clickViewMyCreditHistory()
        CertificationsPage.deleteCEUCredit()
    });

    it('[PURPLE][GREEN] In order to Print CEU Credits', () => {
        HomePage.clickViewMyCreditHistory()
        CertificationsPage.printCEUCredit()
    });

    it('[PURPLE][GREEN] In order to Download Transcripts Credits', () => {

        HomePage.clickViewMyCreditHistory()
        CertificationsPage.transcriptCEUCredit()
    });
  

});