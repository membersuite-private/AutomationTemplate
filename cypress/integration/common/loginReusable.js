import {Given, When, Then} from "@badeball/cypress-cucumber-preprocessor"

import HomePage from "../../../pos/HomePage"

const homepage = new HomePage()

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