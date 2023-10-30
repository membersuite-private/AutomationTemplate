import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CommitteesPage  from '../pos/committeespage'
import example from '../fixtures/example.json'

describe('Committees', () => {
    beforeEach(() => {
        cy.on("uncaught:exception", (e, runnable) => {
            console.log("error", e);
            console.log("runnable", runnable);
            console.log("error", e.message);
            return false;
            });
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
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