import  LoginPage from '../pos/loginpage'
import  CareerCenterPage  from '../pos/careercenterpage'



describe('Carrer Center', () => {
    beforeEach(() => {
        LoginPage.doLogin()
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
  

});