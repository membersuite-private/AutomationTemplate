class OtherAssocPage{
    visitDemonstrationPurple(){
        cy.visit('https://purple.users.purple.membersuite.com/home')
    }

    joinDemonstrationPurple(){
        cy.visit('https://purple.users.purple.membersuite.com/auth/portal-login?isSignUp=true')
    }

    checkMessage(){
        cy.get('.message.ng-star-inserted').should('have.text',' You have an account with another association that uses MemberSuite Universal Login. You can use those same credentials to log in here. You may also reset your password and all accounts will be updated. ')
        cy.get('button').contains('Continue').click()
    }

    clickContinue(){
        cy.get('button').click()
    }

    fillOrganizationFormWithoutOrganization(){
        cy.get('#mat-radio-15 > .mat-radio-label > .mat-radio-container').click({force: true})
        cy.xpath("//button[.=' Next ']").click({force: true})
    }

    fillCreateAccountForm(){
        cy.get("[data-test='input-layout-type']").click({force: true})
        cy.xpath("//span[.= 'Individual Type 3']").click({force: true})
        cy.xpath("//input[@formcontrolname='password']").clear()
        cy.xpath("//input[@formcontrolname='password']").type('Password1!')
        cy.xpath("//button[.=' Next ']").click({force: true})
      }

    changePassword(){
        cy.get('span').contains(' Hi, Test Automat... ').click()
        cy.get("[data-test='menu-reset']").click()
        cy.get('[data-test="reset-current"]').type('Password1!')
        cy.get('[data-test="reset-new"]').type('NewPassword1!')
        cy.get('[data-test="reset-retype"]').type('NewPassword1!')
        cy.get('.reset-button-container').click()
        cy.get('.domain-name > :nth-child(1) > div').contains('Demonstration Purple')
        cy.get('.domain-name > :nth-child(2) > div').contains('MRP BluePay Automation Purple')

    }
  
  
  
  
  }
  
  export default new OtherAssocPage
  