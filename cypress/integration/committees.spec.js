import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  CommitteesPage  from '../pos/committeespage'
import example from '../fixtures/example.json'
import { it } from 'mocha';

describe('Committees', () => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
      });

    it('[PURPLE][GREEN][PRODUCTION] In order to verify browse Committees page', () => {
        HomePage.clickBrowseCommittees()
        CommitteesPage.checkBrowseAllCommitteespage()
        CommitteesPage.clickNewTestingcommittee()
        CommitteesPage.checkNewTestingcommitteeDetails()
    })

    it('[PURPLE][GREEN][PRODUCTION] In order to validate if user can export a list of committees', () => {
        HomePage.clickViewMyCommittees()
        CommitteesPage.click123Committee()
        CommitteesPage.clickExport()
        CommitteesPage.checkDownload()
    })

    it('[PURPLE][GREEN][PRODUCTION] In order to search for a specific committee', () => {
        HomePage.clickViewMyCommittees()
        CommitteesPage.click123Committee()
        CommitteesPage.searchCommittee()
    })

    it('[PURPLE][GREEN][PRODUCTION] In order to validate if user can remove itself from a specific committee', () => {
        HomePage.clickViewMyCommittees()
        CommitteesPage.clickAnotherCommittee()
        CommitteesPage.clickRemoveMySelf()

        //REJOIN TO COMMITTEE
        CommitteesPage.clickJoinThisCommittee()
    })

    it('[PURPLE][GREEN][PRODUCTION] In order to validate if user can join to a new committee', () => {
        HomePage.clickBrowseCommittees()
        CommitteesPage.typeSearchCommittee()
    })

    
});
