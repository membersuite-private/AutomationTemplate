import {Given, When, Then} from "@badeball/cypress-cucumber-preprocessor"

import HomePage from "../../../pos/HomePage"
import Committees from "../../../pos/Committees"

const homepage = new HomePage()
const committees = new Committees()

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

Then("user should be able to click committees",()=>{
    homepage.clickCommittees()
    cy.wait(15)
})

Then("user should be able to click browse committees", ()=>{
    homepage.clickBrowseCommittees()
})

Then("user should be able to verify one of the committees", ()=>{
    committees.checkBrowseAllCommitteespage()
    committees.clickNewTestingcommittee()
    committees.checkNewTestingcommitteeDetails()
})

Then("user should be able to click my committees", ()=>{
        committees.clickMyCommittees()
        committees.checkMyCommitteesPage()
})

Then("user should be able to verify one of the my committees", ()=>{
    committees.checkMyCommitteesPage()
})

