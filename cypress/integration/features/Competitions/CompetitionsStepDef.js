import {Given, When, Then} from "@badeball/cypress-cucumber-preprocessor"

import HomePage from "../../../pos/HomePage"
import Competitions from "../../../pos/Competitions"

const homepage = new HomePage()
const competitions = new Competitions()

When("user should be able to login into users page", ()=>{
    cy.visit(Cypress.env('url'))
    homepage.clickAllowCoockies()
    homepage.clickLogin()
    homepage.fillEmail()
    homepage.fillPassword()
    homepage.clickSignIn()
    cy.wait(5)
    homepage.checkUserProfile()
    homepage.checkHomepage()
})

Then("user should be able to click community",()=>{
    homepage.clickCommunity()
    
})

Then("user should be able to click view competitions on competitions",()=>{
    homepage.clickCompetitions()
    homepage.clickViewOpenCompetiotions()
    
})

Then("user should be able to choose competition type on view competitions",()=>{
    competitions.checkBrowseCompetitionsPage()
    
})

Then("user should be able to select one of competitions",()=>{
    competitions.clickTumonat10competition()
    competitions.checkTumonat10competitionDetail()
    
})

Then("user should be able to enter and arrange entry fee",()=>{
    competitions.clickEnterNow()
    
})

Then("user should be able to fill out information and save as draft on competition",()=>{
    competitions.tumonat10competitionFormInformation()
    competitions.clickSaveasDraft()
    competitions.popUpCompetitionEntry()
    competitions.clickGoHome()
    
})

Then("user should be able to click view my competitions on competitions",()=>{
    homepage.clickCompetitions()
    homepage.clickViewMyCompetiotionsEntries()
})

Then("user should be able to see one of the competitions",()=>{
    competitions.checkMyCompetitionEntriesPage()
})

Then("user should be able to click judging center on competitions",()=>{
    homepage.clickCompetitions()
    homepage.clickJudgingCenter()
})

Then("user should be able to see one of the judgin bucket",()=>{
    competitions.checkJudgeCenterPage()
})


