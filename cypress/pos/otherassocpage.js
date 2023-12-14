class OtherAssocPage{
    visitDemonstration(environment){
        if(environment == 'PURPLE'){
            cy.visit('https://purple.users.purple.membersuite.com/home')
        }
        if(environment == 'GREEN'){
            cy.visit('https://qa.users.green.membersuite.com/home')
        }
        else{
            cy.visit('https://quang.users.membersuite.com/home')
        };
        
    }

    joinDemonstration(environment){
        if(environment == 'PURPLE'){
            cy.visit('https://purple.users.purple.membersuite.com/auth/portal-login?isSignUp=true')
        }
        if(environment == 'GREEN'){
            cy.visit('https://qa.users.green.membersuite.com/auth/portal-login?isSignUp=true')
        }
        if(environment == 'PRODUCTION'){
            cy.visit('https://quang.users.membersuite.com/auth/portal-login?isSignUp=true')
        }
        else{
            
        }

        
    }

    fillCreateAccountForm(environment){
        cy.get("[data-test='input-layout-type']").click({force: true})

        if(environment == 'PURPLE'){
            cy.xpath("//span[.= 'Individual Type 3']").click({force: true})
        }
        if(environment == 'GREEN'){
            cy.xpath("//span[.= 'Default']").click({force: true})
        }
        if(environment == 'PRODUCTION'){
            cy.xpath("//span[.= 'Individual']").click({force: true})
            cy.get('#mat-radio-4 > .mat-radio-label > .mat-radio-container > .mat-radio-outer-circle').click({force: true})
            cy.get("[data-test='input-country']").click({force: true})
            cy.xpath("//span[.= 'Canada ']").click({force: true})
            cy.get("[data-test='input-zip']").type('74040',{force: true})

        }
        else{
            
        }


        cy.xpath("//input[@formcontrolname='password']").clear()
        cy.xpath("//input[@formcontrolname='password']").type('Password1!')
        cy.xpath("//button[.=' Next ']").click({force: true})
      }

    checkMessage(){
        cy.get('.message.ng-star-inserted').should('have.text',' You have an account with another association that uses MemberSuite Universal Login. You can use those same credentials to log in here. You may also reset your password and all accounts will be updated. ')
        cy.get('button').contains('Continue').click()
    }

    clickContinue(){
        cy.get('button').click()
    }

    fillOrganizationFormWithoutOrganization(environment){
        if(environment == 'PRODUCTION'){
            cy.get('#mat-radio-9 > .mat-radio-label > .mat-radio-container > .mat-radio-outer-circle').click({force: true})
        }
        else{
            cy.get('#mat-radio-15 > .mat-radio-label > .mat-radio-container').click({force: true})
        }
        cy.xpath("//button[.=' Next ']").click({force: true})
    }

    changePassword(environment){
        cy.get('span').contains(' Hi, Test Automat... ').click()
        cy.get("[data-test='menu-reset']").click()
        cy.get('[data-test="reset-current"]').type('Password1!')
        cy.get('[data-test="reset-new"]').type('NewPassword1!')
        cy.get('[data-test="reset-retype"]').type('NewPassword1!')
        cy.get('.reset-button-container').click()

        if(environment == 'PURPLE'){
            cy.get('div').contains('MRP BluePay Automation Purple')
            cy.get('div').contains('Demonstration Purple')
        }
        if(environment == 'GREEN'){
            cy.get('div').contains('MRP BluePay Automation Green').should('be.visible')
            cy.get('div').contains('Demonstration New').should('be.visible')
        }
        if(environment == 'PRODUCTION'){
            cy.get('div').contains('MRP BluePay Automation Production')
            cy.get('div').contains('Michael Le Sandbox SSD6')
        }
        else{
            
        }

    }
  
  
  
  
  }
  
  export default new OtherAssocPage
  