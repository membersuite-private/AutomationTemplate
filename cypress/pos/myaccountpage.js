// My Account Class

class MyAccountPage {


    checkMyAccountPage(){
      cy.get('[data-test="name"]').should('have.text', 'Test Automation')
      cy.get('[data-test="map-address"] > span').should('have.text','Canton, ')
    }

    clickMyAccount(){
      cy.get('#mat-tab-label-0-2 > .mat-tab-label-content').click()
    }

    clickMyInfo(){
      cy.get('#mat-tab-label-0-0 > .mat-tab-label-content').click()
    }

    AddnewmethodPaymentCreditCard(){
      cy.get('h3').eq(1).should('have.text','Saved Payment Options').click()
      cy.get('[data-test-id="add-new-credit-card"] > .row > .row-invoice > .payment-new-option').click()
      cy.get('#mat-input-0').type('5439750001500222')
      cy.get('#mat-input-1').type('Test Automation')
      cy.get('#mat-select-0 > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click()
      cy.get('#mat-option-4 > .mat-option-text').click()
      cy.get('#mat-select-1 > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click()
      cy.get('#mat-option-15 > .mat-option-text').click()
      cy.get('#mat-input-2').type('321')
      cy.get('.save-button-profile').click()

    }

    AddnewmethodPaymentACH(){
      cy.get('h3').eq(1).should('have.text','Saved Payment Options').click()
      cy.get('[data-test-id="add-new-bank-account"] > .row > .row-invoice > .payment-new-option').click({force:true})
      cy.get('[data-test-id="add-new-bank-account"] > .row > .row-invoice > .payment-new-option').click({force:true})
      cy.get('[data-test="input-ach-routing"]').type('021000021')
      cy.get('[data-test="input-ach-account"]').type('9876543210')
      cy.get('.mat-select-placeholder').click()
      cy.get('.mat-option-text').click()
      cy.get('.save-button').click()
    }

    PayFirstInvoiceHalfValue(){
      cy.get('.mat-checkbox-inner-container.mat-checkbox-inner-container-no-side-margin').eq(0).click()
      cy.get(':nth-child(3) > :nth-child(1) > .row.ng-star-inserted > .mat-form-field > .mat-form-field-wrapper > .mat-form-field-flex > .mat-form-field-infix > [data-test="reset-current"]').type('{backspace}')
      cy.get(':nth-child(3) > :nth-child(1) > .row.ng-star-inserted > .mat-form-field > .mat-form-field-wrapper > .mat-form-field-flex > .mat-form-field-infix > [data-test="reset-current"]').type('1')
      cy.get('.d-none > .mat-raised-button').click()
    }

    PayFirstInvoiceFullValue(){
      cy.get('.mat-checkbox-inner-container.mat-checkbox-inner-container-no-side-margin').eq(0).click()
      cy.get('.d-none > .mat-raised-button').click()
    }

  }
  export default new MyAccountPage
