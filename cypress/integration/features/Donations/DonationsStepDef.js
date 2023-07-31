
import {Given, When, Then} from "@badeball/cypress-cucumber-preprocessor"
import HomePage from "../../../pos/HomePage"
import Donations from "../../../pos/Donations"

const homepage = new HomePage()
const donations = new Donations()

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


Then("user should be able to click view my giving history", ()=>{
    homepage.clickDonations()
    cy.wait(5)
    homepage.clickViewMyGivingDonations()
    cy.wait(5)
})

Then("user should be able to see giving history elements", ()=>{
    donations.checkDonationsHistory()
})

Then("user should be able to change sorting on giving history", ()=>{
    donations.sortingBygiftId()
})




