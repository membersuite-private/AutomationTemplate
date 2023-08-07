import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CareerCenterPage  from '../pos/careercenterpage'
import  Utils from '../support/utils'

// const page = new HomePage()
// const loginPage = new LoginPage()
// const careerCenterpage = new CareerCenterPage()

describe('Home Page loads when user opens application in browser', () => {
    beforeEach(() => {
        const credentials = {
            realuser: {
                email: 'testautomation@yoip.com',
                passwd: 'Password1!',
            },
        }
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin(credentials.realuser)
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