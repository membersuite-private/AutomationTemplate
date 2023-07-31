import {Given, When, Then} from "@badeball/cypress-cucumber-preprocessor"

import HomePage from "../../../pos/HomePage"
import Discussions from "../../../pos/Discussions"

const homepage = new HomePage()
const discussions = new Discussions()

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

Then("user should be able to click view Discussion Board on Discussions",()=>{
    homepage.clickDiscussions()
    homepage.clickViewDiscussionBoard()
})

Then("user should be able to verify view Discussion Board",()=>{
    discussions.checkDiscussionBoard()
})

Then("user should be able to see one of the discussion boards",()=>{
    discussions.clickWhatsColorIsTheBest()
    discussions.checkDiscussionForum()
})

Then("user should be able to click view my Topic Subscriptions",()=>{
    homepage.clickDiscussions()
    homepage.clickViewMyTopicSubscriptions()
})

Then("user should be able to verify view my Topic Subscriptions",()=>{
    discussions.checkMyTopicSubscriptions()
})



