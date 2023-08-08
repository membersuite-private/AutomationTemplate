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
    cy.get('.mat-radio-outer-circle').click()
  }

}

export default new DonationsPage
