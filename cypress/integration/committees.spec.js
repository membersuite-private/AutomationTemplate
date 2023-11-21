import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CommitteesPage  from '../pos/committeespage'
import example from '../fixtures/example.json'

describe('Committees', () => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickCommunity()
        HomePage.clickCommittees()
      });

    it('[PURPLE][GREEN][PRODUCTION] In order to verify browse Committees page', () => {
        HomePage.clickBrowseCommittees()
        CommitteesPage.checkBrowseAllCommitteespage()
        CommitteesPage.clickNewTestingcommittee()
        CommitteesPage.checkNewTestingcommitteeDetails()
    })

});