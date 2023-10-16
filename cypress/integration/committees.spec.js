import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CommitteesPage  from '../pos/committeespage'
import  Utils from '../support/utils'

describe('Committees', () => {
    beforeEach(() => {
        LoginPage.doLogin()
        HomePage.clickCommunity()
        HomePage.clickCommittees()
      });

    it('In order to verify browse Committees page', () => {
        HomePage.clickBrowseCommittees()
        CommitteesPage.checkBrowseAllCommitteespage()
        CommitteesPage.clickNewTestingcommittee()
        CommitteesPage.checkNewTestingcommitteeDetails()
    })

});