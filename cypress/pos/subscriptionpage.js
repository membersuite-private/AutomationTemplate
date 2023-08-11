class SubscriptionPage{
  checkPublicationPage(){
    // cy.get('#subscription-3e884907-e267-4139-9ced-40fcf81557fe').should('have.text','Publications')
    cy.get('#subscription-sub-h4-TheFamilyHandymanLBA').should('have.text',' The Family Handyman - LBA ')
    cy.get('#subscription-sub-span1-TheFamilyHandymanLBA').should('have.text','Subscription Fee')
    cy.get('#subscription-sub-label1-TheFamilyHandymanLBA').should('have.text','$3.00 ')
  }

  clickAddtoCart(){
    cy.get('#subscription-sub-button1-TheFamilyHandymanLBA').click()
    cy.get('#subscription-67acc9ae-eef0-4fd1-bed5-beb07e1554c9').should('be.visible')
    cy.get('#subscription-2350939f-7f42-466c-abd1-c6259026ea28').contains(' The Family Handyman - LBA ').should('be.visible')
    cy.get('#subscription-094280ec-bd9d-4fbf-8b83-b8cd209e497d').click()
    cy.get('[data-test="checkout-button"]').click()
  }

  thankyoupopup(){
    cy.get('.header-note').should('have.text',' Thank you! ')
    cy.get('.title').should('have.text',' Your order was successful testautomation@yoip.com ')
    cy.get('.col-10 > .col-12').should('have.text',' Please choose one of the options below:   ')
    cy.get('.button-blue').should('have.text',' Close ')
    cy.get('.buttons > :nth-child(2)').click()

  }

  checkMySubscription(){
    cy.get('.view-my-subscription-header > p').should('have.text','My Subscriptions')
    cy.get(':nth-child(1) > .detail').should('have.text','The Family Handyman - LBA')
    cy.get('.view-my-subscription-table-data > :nth-child(2) > .detail').should('have.text','06/26/2023')
    cy.get(':nth-child(4) > .detail').should('have.text','Test Automation')
    cy.get(':nth-child(5) > .detail').should('have.text','0')

  }


}

export default new SubscriptionPage
