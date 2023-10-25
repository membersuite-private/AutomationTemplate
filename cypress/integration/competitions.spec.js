import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import CompetitionsPage from '../pos/competitionspage'
import example from '../fixtures/example.json'


describe('Competitions',() => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickCommunity()
        HomePage.clickCompetitions()

      });

      it('In order to view open competitions page', () => {
        HomePage.clickViewOpenCompetiotions()
        CompetitionsPage.checkBrowseCompetitionsPage()
        CompetitionsPage.clickTumonat10competition()
        CompetitionsPage.checkTumonat10competitionDetail()
        CompetitionsPage.clickEnterNow()
        CompetitionsPage.tumonat10competitionFormInformation()
        CompetitionsPage.clickSaveasDraft()
        CompetitionsPage.popUpCompetitionEntry()
        CompetitionsPage.clickGoHome()


      });

      it('In order to view  my competition entries page', () => {
        HomePage.clickViewMyCompetiotionsEntries()
        CompetitionsPage.checkMyCompetitionEntriesPage()

      });


      it('In order to view  judging center page', () => {
        HomePage.clickJudgingCenter()
        CompetitionsPage.checkJudgeCenterPage()

      });

});
