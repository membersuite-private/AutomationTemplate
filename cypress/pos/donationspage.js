class DonationsPage{
  checkDonationsHistory(){
      cy.get('h2').contains('My Giving History').should('be.visible')
      cy.get('h2').contains('My Open Pledges and Recurring Gifts').should('be.visible')
  }

  sortingBygiftId(){
      cy.get('button').contains('Gift#').should("be.visible")
      cy.get('button').contains('Gift#').click()
      cy.get('mat-cell').eq(1).contains('10714')
  }

  clickFundraisingProduct01(){
    cy.get('input').check({force: true})
  }

  fillDonationForm(){
    cy.get('[data-test="shipping-address-1"]').type('6764 Hickory Flat Highway')
    cy.get('[data-test="shipping-city"]').type('Canton')
    cy.get('[data-test="shipping-state"]').click()
    cy.get('#donation-option-Alabama > .mat-option-text').click()
    cy.get('[data-test="shipping-zip-code"]').type('30115')
    cy.get('[data-test="input-card-number"]').type('4111111111111111')
    cy.get('[data-test="input-holder-name"]').type('omerinvalid')
    cy.get('[data-test="input-exp-month"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click()
    cy.get('#donation-option-03 > .mat-option-text').click()
    cy.get('[data-test="input-exp-year"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click()
    cy.get('#donation-option-27 > .mat-option-text').click()
    cy.get('[data-test="input-sec-code"]').type('123')
    cy.xpath("//button[normalize-space()='Continue']").click()
  }

  fillDonationFormExpiredCard(){
    cy.get('[data-test="shipping-address-1"]').type('6764 Hickory Flat Highway')
    cy.get('[data-test="shipping-city"]').type('Canton')
    cy.get('[data-test="shipping-state"]').click()
    cy.get('#donation-option-Alabama > .mat-option-text').click()
    cy.get('[data-test="shipping-zip-code"]').type('30115')
    cy.get('[data-test="input-card-number"]').type('4111111111111111')
    cy.get('[data-test="input-holder-name"]').type('omerinvalid')
    cy.get('[data-test="input-exp-month"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click()
    cy.get('#donation-option-03 > .mat-option-text').click()
    cy.get('[data-test="input-exp-year"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click()
    cy.get('#donation-option-23 > .mat-option-text').click()
    cy.get('[data-test="input-sec-code"]').type('123')
    cy.xpath("//button[normalize-space()='Continue']").click()
  }

  checkCheckoutPage(){
    // cy.get('#donation-span1-Fund01').should('have.text','Fund 01')
    cy.get('[data-test="donation-name"]').should('have.text',' Fundraising Product 01')
    cy.get('[data-test="fee-price"]').should('have.text',' $11.00 ')
    cy.get('[data-test="subtotal"]').should('have.text','$11.00')
    cy.get('#footer-50c8321f-d01d-48ff-843b-bb2ee66da705').should('have.text',' $11.00 ')
    cy.get('#footer-b81bac0a-2757-4356-a4b8-61b6f0fac3cd').click()

  }

  donationSuccessfulPopUp(){
    cy.get('#modal-4704ae47-a3e4-4b4c-b144-08583eb5367d').should('have.text',' Donation Successful ')
    cy.get('#modal-629cde2a-e221-4653-9828-401baae9a569').click()
  }

  donationFailedCardExpired(){
    cy.get('#modal-4704ae47-a3e4-4b4c-b144-08583eb5367d').should('have.text', 'Processing Failed')
    cy.get('#modal-72290bb7-115b-4648-a4f4-94642e28f95d').should('have.text', 'Card Expired')
  }

}

export default new DonationsPage
