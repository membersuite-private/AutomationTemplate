class ShopPage{
  checkBrowseShopPage(){
    cy.get('[data-test="store-search"]').should('be.visible')
    cy.get('[data-test="product-name"]').eq(5).should('have.text','BluePay')
  }

  clickBluePay(){
    cy.get('[data-test="product-name"]').eq(5).click()
  }

  checkBluepayPage(){
    cy.get('[data-test="product-name-desktop"]').should('have.text',' BluePay ')
    cy.get('.price-qty-container > [data-test="product-price"]').should('have.text',' $5.00 ')
    cy.get('.add-button-style > [data-test="add-button"]').should('have.text',' Add To Cart ')
  }

  clickAddToCart(){
    cy.get('.add-button-style > [data-test="add-button"]').click()
  }

  clickAddTwoItensToCart(){
    // cy.get('span').should('have.class','incr-btn plus-group').eq(2).click({force: true})
    cy.get('.incr-btn.plus-group').eq(1).click()
    cy.get('.incr-val').eq(1).should('have.text','2')
    cy.get('.add-button-style > [data-test="add-button"]').click()
  }

  checkPopUpCart(quantity,items){
    cy.get('.ng-star-inserted').should('contain', ' The following item was added to the cart  ')
    cy.get('.added-product-name').should('contain', ' BluePay ')
    cy.get('.incr-val').should('contain', quantity)
    // cy.get('.incr-val').should('contain', 'Qty: 1')
    cy.get('.ng-star-inserted').should('contain', ' $5.00 ')
    cy.get('.ng-star-inserted').should('contain', items)
    cy.get('.button-white').should('contain', ' Keep Shopping ')
    cy.get('.continue-to-cart').should('be.visible')
  }

  // checkPopUpCart(){
  //   cy.get('.ng-star-inserted').should('contain', ' The following item was added to the cart  ')
  //   cy.get('.added-product-name').should('contain', ' BluePay ')
  //   cy.get('.incr-val').should('contain', 'Qty: 1')
  //   cy.get('.ng-star-inserted').should('contain', ' $5.00 ')
  //   cy.get('.ng-star-inserted').should('contain', ' (1 Item)')
  //   cy.get('.button-white').should('contain', ' Keep Shopping ')
  //   cy.get('.continue-to-cart').should('be.visible')
  // }

  clickContinueToCart(){
    cy.get('.continue-to-cart').click()
  }

  clickCheckout(price){
    cy.get('[data-test="product-name"]').should('have.text', 'BluePay')
    cy.get('[data-test="product-price"]').should('have.text', price)
    cy.get('[data-test="checkout-button"]').click()
  }

  fillFormUsingExistingValues(){
    cy.get('.mat-radio-label-content').eq(0).click({force: true})
    // cy.get('input').eq(0).trigger("click")
    cy.get('[data-test="shipping-address-existing-0"]').click()
    // cy.get('.billing-address-view-section').eq(4).click({force: true})
    // cy.get('input').eq(4).trigger("click")
    // cy.get('input').eq(0).click({force: true})
    cy.get('button').eq(1).should('have.text',' Checkout ').click({force: true})
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

  checkSummary(productPrice,productTotal,taxPrice){
    cy.get('[data-test="product-name-0"]').should('have.text',' BluePay ')
    cy.get('.product-price').should('have.text',productPrice)
    cy.get('[data-test="product-total-0"]').should('have.text',productTotal)
    cy.get('[data-test="tax-price"]').should('have.text',taxPrice)
    cy.get('.total-price').eq(1).should('have.text',productTotal)
  }
  
}

export default new ShopPage
