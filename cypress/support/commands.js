// ***********************************************
// This example commands.js shows you how to
// create various custom commands and overwrite
// existing commands.
//
// For more comprehensive examples of custom
// commands please read more here:
// https://on.cypress.io/custom-commands
// ***********************************************
//
//
// -- This is a parent command --
// Cypress.Commands.add('login', (email, password) => { ... })
//
//
// -- This is a child command --
// Cypress.Commands.add('drag', { prevSubject: 'element'}, (subject, options) => { ... })
//
//
// -- This is a dual command --
// Cypress.Commands.add('dismiss', { prevSubject: 'optional'}, (subject, options) => { ... })
//
//
// -- This will overwrite an existing command --
// Cypress.Commands.overwrite('visit', (originalFn, url, options) => { ... })

import 'cypress-xpath';

Cypress.Commands.add("GetOwnerId",()=>{
    cy.fixture('tokens').then((tokens)  => {
        let idToken = tokens.idToken
        let accessToken = tokens.accessToken
        

        cy.request({
            method: 'GET',
            url: "https://rest-purple-internal.financial.membersuite.com/platform/v2/whoami",
            headers: {
            'Authorization': 'Bearer '+ idToken
            }  
        })
        .then(function(response){
            // expect(response.status).to.eq(200)
            Cypress.env('ownerId', response.body.ownerId)
            Cypress.env('userId', response.body.userId)
            cy.log('ownerId --- '+ Cypress.env('ownerId'))
            cy.log('userId --- '+ Cypress.env('userId'))

            cy.writeFile('cypress/fixtures/tokenowner.json',{ 
                ownerId: Cypress.env('ownerId'),
                idToken: tokens.idToken
            })
        })

        // cy.wait(60000)
            
        // .then(function(response){
        //     cy.request({
        //         method: 'DELETE',
        //         url: "https://rest-purple-internal.financial.membersuite.com/platform/v2/dataSuite/delete/" + Cypress.env('ownerId'),
        //         headers: {
        //         'Authorization': 'Bearer '+ idToken,
        //         'Asynchronous': 'false'
        //         }  
        //     })
    
        // })

        
    })

})

Cypress.Commands.add("DeleteRequest",()=>{
        cy.fixture('tokenowner').then((tokenowner) => {
            let ownerId = tokenowner.ownerId
            let idToken = tokenowner.idToken
            cy.log(ownerId)

            cy.request({
                method: 'DELETE',
                url: "https://rest-purple-internal.financial.membersuite.com/platform/v2/dataSuite/delete/" + ownerId,
                headers: {
                'Authorization': 'Bearer '+ idToken,
                'Asynchronous': 'false'
                }  
            })
        })
    
        
   
})

Cypress.Commands.add("GetTokenAuthentication",(email)=>{
    cy.log(email)
    cy.request({
        method: "POST",
        url: "https://express-purple.portal.financial.membersuite.com/stage/platform/login/35735",
        body: {
            "email": email,
            "password":"Password1!"
        }    
    })

    .then(function(response){
        // expect(response.status).to.eq(200)
        Cypress.env('accessToken',response.body.data.accessToken)
        Cypress.env('idToken',response.body.data.idToken)
        Cypress.env('refreshToken',response.body.data.refreshToken)

        cy.writeFile('cypress/fixtures/tokens.json',{ 
            accessToken: Cypress.env('accessToken'), 
            idToken: Cypress.env('idToken'),
            refreshToken: Cypress.env('refreshToken') 
        })

        cy.log(Cypress.env('idToken'))
    })
    
    
})
