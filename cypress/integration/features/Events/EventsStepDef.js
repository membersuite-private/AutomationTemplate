
import {Given, When, Then} from "@badeball/cypress-cucumber-preprocessor"
import HomePage from "../../../pos/HomePage"
import Events from "../../../pos/Events"

const homepage = new HomePage()
const events = new Events()

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

Then("user should be able to click events on main page", ()=>{
    homepage.checkHomepage()
    homepage.clickEvents()
    cy.wait(5)

})

Then("user should be able to register two new individual", ()=>{
    events.checkEventsPage()
    events.clickOnGrpEvent()
    events.checkEventDetails()
    events.clickRegister()
})

Then("user should be able to click my events on Events", ()=>{
    homepage.clickMyEvents()
})

Then("user should be able to click my exhibits on Events", ()=>{
    homepage.clickMyExhibits()
})

