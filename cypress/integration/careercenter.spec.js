import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CareerCenterPage  from '../pos/careercenterpage'
import  Utils from '../support/utils'


describe('Carrer Center', () => {
    beforeEach(() => {
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin()
        HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
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