class ShopPage{
  checkBrowseShopPage(){
    cy.get('[data-test="store-search"]').should('be.visible')
    cy.get('[ng-reflect-router-link="/shop/store,a11f139a-00ce-cd0f"] > .store-item > .item-content > .ng-star-inserted > .col-12 > [data-test="product-name"]').should('be.visible')
  }

  clickBluePay(){
    cy.get('[ng-reflect-router-link="/shop/store,a11f139a-00ce-cd0f"] > .store-item > .item-content > .ng-star-inserted > .col-12 > [data-test="product-name"]').click()
  }

  checkBluepayPage(){
    cy.get('[data-test="product-name-desktop"]').should('have.text',' BluePay ')
    cy.get('.price-qty-container > [data-test="product-price"]').should('have.text',' $5.00 ')
    cy.get('.add-button-style > [data-test="add-button"]').should('have.text',' Add To Cart ')
  }

  clickAddToCart(){
    cy.get('.add-button-style > [data-test="add-button"]').click()
  }

  checkPopUpCart(){
    cy.get('#subscription-67acc9ae-eef0-4fd1-bed5-beb07e1554c9').should('have.text', ' The following item was added to the cart  ')
    cy.get('#subscription-2350939f-7f42-466c-abd1-c6259026ea28').should('have.text', ' BluePay ')
    cy.get('#subscription-53c6862d-ba06-42e7-b2af-8dc54565dfba').should('have.text', 'Qty: 1')
    cy.get('#subscription-de57cef7-5b9f-4c6e-9a5a-c1dccecea9c3').should('have.text', ' $5.00 ')
    // cy.get('#subscription-fc43ee20-5628-43b5-9d44-5cf78d43ceb6').should('have.text', ' Subtotal (1 Item): $5.00')
    cy.get('#subscription-9fce680f-1347-48c1-bd84-8ddfe7c592f2').should('have.text', ' Keep Shopping ')
    cy.get('#subscription-094280ec-bd9d-4fbf-8b83-b8cd209e497d').should('be.visible')
  }

  clickContinueToCart(){
    cy.get('#subscription-094280ec-bd9d-4fbf-8b83-b8cd209e497d').click()
  }

  clickCheckout(){
    cy.get('[data-test="product-name"]').should('have.text', 'BluePay')
    cy.get('[data-test="product-price"]').should('have.text', ' $5.00 ')
    cy.get('[data-test="checkout-button"]').click()
  }

  fillFormUsingExistingValues(){
    cy.get('input').eq(0).check({force: true})
    cy.get('input').eq(4).check({force: true})
    cy.get('input').eq(0).click({force: true})
    cy.get('#footer-b81bac0a-2757-4356-a4b8-61b6f0fac3cd').click()
  }

  fillFormUsingPaylater(){
    cy.get('input').eq(2).check({force: true})
    cy.get('input').eq(4).check({force: true})
    cy.get('input').eq(2).click({force: true})
    cy.get('#footer-b81bac0a-2757-4356-a4b8-61b6f0fac3cd').click()
  }

  checkThankYouPopUp(){
    cy.get('.title').should('have.text',' Thank you!  ')
    cy.get('.col-10 > .col-12').should('have.text',' Order Successful testautomation@yoip.com  ')
    cy.get('.buttons > .button').click()
  }



}

export default new ShopPage
