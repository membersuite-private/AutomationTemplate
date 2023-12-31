class CertificationsPage{
    checkReportEditCEUCreditsPopUp(){
        cy.get('h3').contains('Report/Edit CEU Credits')
        cy.get('p').contains('Please fill out the fields below:')
        cy.get('p').contains('Self reported credits will need to be verified by the association staff.')
        cy.get('[data-test="Ceu-type"]').should('be.visible')
        cy.get('#mat-input-0').should('be.visible')
        cy.get('[name="creditDate"]').should('be.visible')
        cy.get('#mat-input-2').should('be.visible')
        cy.get('button').contains('Cancel')
        cy.get('button').contains('Save')
    }

    fillCEUCreditsForm(){
        cy.get('[data-test="Ceu-type"]').click()
        cy.get('span').contains('CEU type 1').click()
        cy.get('#mat-input-0').type('1')
        cy.get('#mat-input-1').type('10/11/2023')
        cy.get('#mat-input-2').type('Description')
        cy.get('button').contains('Save').click()
      }

    checkMyCEUCreditHistory(){
      cy.get('h4').contains('My CEU Credit History')  
      cy.get('.header-description').contains('Only unverified credits can be edited or deleted. Unverified credits will appear in italics.')
      cy.get('span').contains('Refine').should('be.visible')
      cy.get('span').contains('Download Transcript').should('be.visible')
      cy.get('button').contains('+ Report CEU Credits').should('be.visible')
    }

    editCEUCredit(){
      cy.get('.mat-radio-container').eq(0).click()
      cy.get('.text-area').contains('Edit').click({force: true})
      cy.get('[name="quantity"]').type('2')
      cy.get('button').contains('Save').click()
    }

    deleteCEUCredit(){
      cy.get('.mat-radio-container').eq(0).should('be.visible')
      cy.get('.mat-radio-container').eq(0).click({force: true})
      cy.get('.text-area').contains('Delete').click({force: true})
      cy.get('button').contains('Delete').click()
    }

    printCEUCredit(){
      cy.get('.mat-radio-container').eq(0).click()
      cy.get('.text-area').contains('Print').click({force: true})
    }

    transcriptCEUCredit(){
      cy.get('.mat-radio-container').eq(0).click()
      cy.get('.fa > .reine-filter').contains('Download Transcript').click({force: true})
    }

    
  }
  
  export default new CertificationsPage
  