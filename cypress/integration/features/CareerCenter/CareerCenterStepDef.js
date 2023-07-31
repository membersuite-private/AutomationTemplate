
import {Given, When, Then} from "@badeball/cypress-cucumber-preprocessor"
import HomePage from "../../../pos/HomePage"
import CareerCenter from "../../../pos/CareerCenter"

const homepage = new HomePage()
const careercenter = new CareerCenter()

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
    homepage.checkHomepage()
    homepage.clickCommunity()
    
})

Then("user should be able to click Career Center",()=>{
    homepage.clickCarrerCenter()
    careercenter.checkCarrerPage()
})

Then("user should be able to click on find a job",()=>{
    careercenter.clickSearch()
})

Then("user should be able to apply one of the job post",()=>{
    careercenter.click130pm()
    careercenter.view130pmDetails()
})

Then("user should be able to click on Employers and search resumes on Employers",()=>{
    careercenter.clickEmployersTab()
})
Then("user should be able to see Resume results",()=>{
    careercenter.clickSearch()
})

