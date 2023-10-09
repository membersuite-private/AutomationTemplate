import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CommitteesPage  from '../pos/committeespage'
import  Utils from '../support/utils'

describe('Committees', () => {
    beforeEach(() => {
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin()
        HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
        Utils.wait(5)
        HomePage.clickCommunity()
      });

    it('In order to verify browse Committees page', () => {
        HomePage.clickCommittees()
        Utils.wait(5)
        // HomePage.clickBrowseCommittees()
        // CommitteesPage.checkBrowseAllCommitteespage()
        // CommitteesPage.clickNewTestingcommittee()
        // CommitteesPage.checkNewTestingcommitteeDetails()
    })

});