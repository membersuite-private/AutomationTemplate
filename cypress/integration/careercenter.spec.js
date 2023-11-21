import  LoginPage from '../pos/loginpage'
import  CareerCenterPage  from '../pos/careercenterpage'
import example from '../fixtures/example.json'



describe('Carrer Center', () => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        CareerCenterPage.chooseCareerCenterinMenu()
        CareerCenterPage.checkCareerCenterPageElements()
      });


    it('[PURPLE][GREEN][PRODUCTION] In order to verify find job on Career Center page', () => {
        CareerCenterPage.clickSearch()
        CareerCenterPage.click130pm()
        CareerCenterPage.view130pmDetails()
    });

    it('[PURPLE][GREEN][PRODUCTION] In order to verify view Employers page', () => {
        CareerCenterPage.clickEmployersTab()
        CareerCenterPage.clickSearch()
    })

    it('[PURPLE][GREEN][PRODUCTION] In order to Post a Job on Employers page', () => {
        CareerCenterPage.clickEmployersTab()
        CareerCenterPage.clickPostaJob()
        CareerCenterPage.fillJobPosting()
        CareerCenterPage.checkJobPostingPage()
        CareerCenterPage.clickConfirm()
        CareerCenterPage.jobConfirmation()
    })


  

});