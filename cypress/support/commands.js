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

Cypress.Commands.add("GetOwnerId",(environment)=>{
    cy.fixture('tokens').then((tokens)  => {
        let idToken = tokens.idToken
        let accessToken = tokens.accessToken
        
        if(environment == 'PURPLE'){
            cy.request({
                method: 'GET',
                url: "https://rest-purple-internal.financial.membersuite.com/platform/v2/whoami",
                headers: {
                'Authorization': 'Bearer '+ idToken
                }  
            })
            .then(function(response){
                Cypress.env('ownerId', response.body.ownerId)
                Cypress.env('userId', response.body.userId)
                cy.log('ownerId --- '+ Cypress.env('ownerId'))
                cy.log('userId --- '+ Cypress.env('userId'))

                cy.writeFile('cypress/fixtures/tokenowner.json',{ 
                    ownerId: Cypress.env('ownerId'),
                    idToken: tokens.idToken
                })
            })
        }

        if(environment == 'GREEN'){
            cy.request({
                method: 'GET',
                url: "https://express.portal.financial.membersuite.com/qa/auth/whoAmI",
                headers: {
                'Authorization': 'Bearer '+ idToken
                }  
            })
            .then(function(response){
                Cypress.env('ownerId', response.body.ownerId)
                Cypress.env('userId', response.body.userId)
                cy.log('ownerId --- '+ Cypress.env('ownerId'))
                cy.log('userId --- '+ Cypress.env('userId'))

                cy.writeFile('cypress/fixtures/tokenowner.json',{ 
                    ownerId: Cypress.env('ownerId'),
                    idToken: tokens.idToken
                })
            })
        }

        if(environment == 'PRODUCTION'){
            cy.request({
                method: 'GET',
                url: "https://rest-purple-internal.financial.membersuite.com/platform/v2/whoami",
                headers: {
                'Authorization': 'Bearer '+ idToken
                }  
            })
            .then(function(response){
                Cypress.env('ownerId', response.body.ownerId)
                Cypress.env('userId', response.body.userId)
                cy.log('ownerId --- '+ Cypress.env('ownerId'))
                cy.log('userId --- '+ Cypress.env('userId'))

                cy.writeFile('cypress/fixtures/tokenowner.json',{ 
                    ownerId: Cypress.env('ownerId'),
                    idToken: tokens.idToken
                })
            })
        }

        // cy.wait(60000)
        
    })

})

Cypress.Commands.add("DeleteRequest",(email,environment)=>{
        cy.fixture('tokenowner').then((tokenowner) => {
            let ownerId = tokenowner.ownerId
            let idToken = tokenowner.idToken
            cy.log(ownerId)


            if(environment == 'PURPLE'){
                cy.request({
                    method: 'GET',
                    url: "https://rest-purple-internal.financial.membersuite.com/platform/v2/dataSuite/get/"+ ownerId,
                    headers: {
                    'Authorization': 'Bearer '+ idToken
                    }  
                })
                .then(function(response){
                    expect(response.status).to.eq(200)
                    expect(response.body.data.fields.name).to.eq('Test Automation')
                    expect(response.body.data.fields.emailAddress).to.eq(email)
                },{failOnStatusCode: false})
            

                let curl = "curl -X DELETE --header 'Accept: application/json' --header 'Authorization: Bearer "+ idToken +"' --header 'Asynchronous: false' 'https://rest-purple-internal.financial.membersuite.com/platform/v2/dataSuite/delete/"+ ownerId+"'"
                cy.exec(curl)
            }
            if(environment == 'GREEN'){
                cy.request({
                    method: 'GET',
                    url: "https://rest-purple-internal.financial.membersuite.com/platform/v2/dataSuite/get/"+ ownerId,
                    headers: {
                    'Authorization': 'Bearer '+ idToken
                    }  
                })
                .then(function(response){
                    expect(response.status).to.eq(200)
                    expect(response.body.data.fields.name).to.eq('Test Automation')
                    expect(response.body.data.fields.emailAddress).to.eq(email)
                },{failOnStatusCode: false})
            

                let curl = "curl -X DELETE --header 'Accept: application/json' --header 'Authorization: Bearer "+ idToken +"' --header 'Asynchronous: false' 'https://rest-purple-internal.financial.membersuite.com/platform/v2/dataSuite/delete/"+ ownerId+"'"
                cy.exec(curl)
            }
            if(environment == 'PRODUCTION'){
                cy.request({
                    method: 'GET',
                    url: "https://rest-purple-internal.financial.membersuite.com/platform/v2/dataSuite/get/"+ ownerId,
                    headers: {
                    'Authorization': 'Bearer '+ idToken
                    }  
                })
                .then(function(response){
                    expect(response.status).to.eq(200)
                    expect(response.body.data.fields.name).to.eq('Test Automation')
                    expect(response.body.data.fields.emailAddress).to.eq(email)
                },{failOnStatusCode: false})
            

                let curl = "curl -X DELETE --header 'Accept: application/json' --header 'Authorization: Bearer "+ idToken +"' --header 'Asynchronous: false' 'https://rest-purple-internal.financial.membersuite.com/platform/v2/dataSuite/delete/"+ ownerId+"'"
                cy.exec(curl)
            }
          
        })

   
})

Cypress.Commands.add("GetTokenAuthentication",(email,environment)=>{
    cy.log(email)

    if(environment == 'PURPLE'){
        cy.request({
            method: "POST",
            url: "https://express-purple.portal.financial.membersuite.com/stage/platform/login/35735",
            body: {
                "email": email,
                "password":"Password1!"
            }    
        }).then(function(response){
            Cypress.env('accessToken',response.body.data.accessToken)
            Cypress.env('idToken',response.body.data.idToken)
            Cypress.env('refreshToken',response.body.data.refreshToken)

            cy.writeFile('cypress/fixtures/tokens.json',{ 
                accessToken: Cypress.env('accessToken'), 
                idToken: Cypress.env('idToken'),
                refreshToken: Cypress.env('refreshToken') 
            })
        })
    }

    if(environment == 'GREEN'){
        cy.request({
            method: "POST",
            url: "https://express.portal.financial.membersuite.com/qa/platform/login/35743",
            body: {
                "email": email,
                "password":"Password1!"
            }    
        }).then(function(response){
            Cypress.env('accessToken',response.body.data.accessToken)
            Cypress.env('idToken',response.body.data.idToken)
            Cypress.env('refreshToken',response.body.data.refreshToken)

            cy.writeFile('cypress/fixtures/tokens.json',{ 
                accessToken: Cypress.env('accessToken'), 
                idToken: Cypress.env('idToken'),
                refreshToken: Cypress.env('refreshToken') 
            })
        })
    }

    if(environment == 'PROD'){
        cy.request({
            method: "POST",
            url: "https://express-purple.portal.financial.membersuite.com/stage/platform/login/35735",
            body: {
                "email": email,
                "password":"Password1!"
            }    
        }).then(function(response){
            Cypress.env('accessToken',response.body.data.accessToken)
            Cypress.env('idToken',response.body.data.idToken)
            Cypress.env('refreshToken',response.body.data.refreshToken)

            cy.writeFile('cypress/fixtures/tokens.json',{ 
                accessToken: Cypress.env('accessToken'), 
                idToken: Cypress.env('idToken'),
                refreshToken: Cypress.env('refreshToken') 
            })
        })
    }







        cy.log(Cypress.env('idToken'))
    })
    
    
