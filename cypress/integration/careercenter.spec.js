import  LoginPage from '../pos/loginpage'
import  CareerCenterPage  from '../pos/careercenterpage'
import example from '../fixtures/example.json'



describe('Carrer Center', () => {
    beforeEach(() => {
        cy.on("uncaught:exception", (e, runnable) => {
            console.log("error", e);
            console.log("runnable", runnable);
            console.log("error", e.message);
            return false;
            });

        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        CareerCenterPage.chooseCareerCenterinMenu()
        CareerCenterPage.checkCareerCenterPageElements()
      });


    it('In order to verify find job on Career Center page', () => {
        CareerCenterPage.clickSearch()
        CareerCenterPage.click130pm()
        CareerCenterPage.view130pmDetails()
    });

    it('In order to verify view Employers page', () => {
        CareerCenterPage.clickEmployersTab()
        CareerCenterPage.clickSearch()
    })

    it('In order to Post a Job on Employers page', () => {
        CareerCenterPage.clickEmployersTab()
        CareerCenterPage.clickPostaJob()
        CareerCenterPage.fillJobPosting()
        CareerCenterPage.checkJobPostingPage()
        CareerCenterPage.clickConfirm()
        CareerCenterPage.jobConfirmation()
    })


  

});