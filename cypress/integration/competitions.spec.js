import  HomePage  from '../pos/homePage'
import  LoginPage from '../pos/loginPage'
import Utils from '../support/utils'
import CompetitionsPage from '../pos/competitionsPage'
import example from '../fixtures/example.json'
// import { util } from 'chai'


describe('Competitions',() => {
    beforeEach(() => {
      LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
      HomePage.clickCommunity()
      HomePage.clickCompetitions()

      });

      it.skip('[PURPLE][GREEN][PRODUCTION] In order to view open competitions page', () => {
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

      it.skip('[PURPLE][GREEN][PRODUCTION] In order to view  my competition entries page', () => {
        HomePage.clickViewMyCompetiotionsEntries()
        CompetitionsPage.checkMyCompetitionEntriesPage()

      });


      it.skip('[PURPLE][GREEN][PRODUCTION] In order to view  judging center page', () => {
        HomePage.clickJudgingCenter()
        CompetitionsPage.checkJudgeCenterPage()

      });

      it('[PURPLE][GREEN][PRODUCTION] In order to validate if user are able to refine search using filter', () => {
        HomePage.clickViewOpenCompetiotions()
        CompetitionsPage.checkBrowseCompetitionsPage()
        CompetitionsPage.clickFilterCompetitionType()
      });

      it.skip('[PURPLE][GREEN] In order to validate if user can continue from a drafted competition', () => {
        HomePage.clickViewMyCompetiotionsEntries()
        CompetitionsPage.checkMyCompetitionEntriesPage()
        CompetitionsPage.sortByStatus()
        CompetitionsPage.clickContinueDraft()
        CompetitionsPage.checkCompetitionEntryConfirmation()
      });

      it.skip('[PURPLE][GREEN][PRODUCTION] In order to registered judge being able to validate a round', () => {
        const randomScore = Utils.generateRandomNumbers(1,100)
        HomePage.clickJudgingCenter()
        CompetitionsPage.checkJudgeCenterPage()
        CompetitionsPage.clickViewEntry(randomScore)
        CompetitionsPage.checkJudgingRound(randomScore)
      });

});
