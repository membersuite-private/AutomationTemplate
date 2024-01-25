class ShopPage{
  checkBrowseShopPage(){
    cy.get('[data-test="store-search"]').should('be.visible')
    cy.get('[data-test="product-name"]').eq(5).should('have.text','BluePay')
  }

  clickBluePay(){
    cy.get('[data-test="product-name"]').contains('BluePay').click({force: true})
  }

  clickPenny(){
    cy.get('[data-test="product-name"]').eq(21).should('have.text','Penny').click()
  }

  clickItem(){
    cy.get('[data-test="product-name"]').as('productName')
    cy.get('@productName').each(($el,index,$list) => {
      const textProduct=$el.find('span.product-name').text()
      if(textProduct.includes('Penny')){
        cy.wrap($el).click()
      }
    })
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
    cy.get('.incr-btn.plus-group').eq(1).click()
    cy.get('.incr-val').eq(1).should('have.text','2')
    cy.get('.add-button-style > [data-test="add-button"]').click()
  }

  checkPopUpCart(quantity,items){
    cy.get('.ng-star-inserted').should('contain', ' The following item was added to the cart  ')
    cy.get('.added-product-name').should('contain', ' BluePay ')
    cy.get('.incr-val').should('contain', quantity)
    cy.get('.ng-star-inserted').should('contain', ' $5.00 ')
    cy.get('.ng-star-inserted').should('contain', items)
    cy.get('.button-white').should('contain', ' Keep Shopping ')
    cy.get('.continue-to-cart').should('be.visible')
  }

  clickContinueToCart(){
    cy.get('.continue-to-cart').click()
  }

  clickCheckout(name,price){
    cy.get('[data-test="product-name"]').should('have.text', name)
    cy.get('[data-test="product-price"]').should('have.text', price)
    cy.get('[data-test="checkout-button"]').click()
  }

  fillFormUsingExistingValues(){
    cy.get('.mat-radio-label-content').eq(0).click({force: true})
    cy.get('[data-test="shipping-address-existing-0"]').click()
    cy.get('button').eq(1).should('have.text',' Checkout ').click({force: true})
  }

  fillFormUsingExistingValuesInvoice(){
    cy.get('.mat-radio-label-content').eq(1).click({force: true})
    cy.get('[data-test="shipping-address-existing-0"]').click()
    cy.get('.button.button-blue').should('have.text',' Checkout ').click({force: true})
  }

  fillFormUsingDiscountCode(){
    cy.get('.mat-radio-label-content').eq(0).click({force: true})
    cy.get('[data-test="input-promo-code"]').type('CODEDISCOUNT')
    cy.get('.button-promo-code.column > .button').click()
    cy.get('.icon-checkmark-circle').should('be.visible')
    cy.get('.product-name.promo.col-8').should('be.visible')
    cy.get('.product-name.promo.col-8').should('have.text','Promo Code: CODEDISCOUNT')
    cy.get('.price.promo.col-4').should('have.text','(-$5.00)')
    cy.get('[data-test="shipping-address-existing-0"]').click()
    cy.get('button').eq(1).should('have.text',' Checkout ').click({force: true})
  }

  fillFormUsingPaylater(){
    cy.get('.mat-radio-label-content').eq(2).click({force: true})
    cy.get('[data-test="shipping-address-existing-0"]').click()
    cy.get('button').eq(1).should('have.text',' Checkout ').click({force: true})
  }

  fillFormUsingNewPayment(){
    cy.get('.mat-radio-label-content').eq(1).click({force: true})
    cy.wait(2)
    cy.get('[data-test="input-card-number"]').type('4242424242424242', { force: true })
    cy.get('[data-test="input-holder-name"]').type('MemberSuite Test', { force: true })
    cy.get('[data-test="input-exp-month"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click({ force: true })
    cy.get('#mat-option-4 > .mat-option-text').click({ force: true })
    cy.get('[data-test="input-exp-year"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click({ force: true })
    cy.get('#mat-option-19 > .mat-option-text').click({ force: true })
    cy.get('[data-test="input-sec-code"]').type('123', { force: true })
    cy.get('[data-test="shipping-address-existing-0"] > .mat-radio-label > .mat-radio-container > .mat-radio-outer-circle').click({ force: true })
    cy.get('button').eq(2).should('have.text',' Checkout ').click({force: true})
  }

  fillFormUsingNewPaymentACH(){
    cy.get('.mat-radio-label-content').eq(1).click({force: true})
    cy.wait(2)
    cy.get(':nth-child(3) > :nth-child(3)').click({force: true})
    cy.get('[data-test="input-ach-routing"]').type('091000019',{force: true})
    cy.get('[data-test="input-ach-account"]').type('1234567',{force: true})
    cy.get('.save-button').click({force: true})
    cy.get('[data-test="shipping-address-existing-0"]').click()
    cy.get('button').eq(1).should('have.text',' Checkout ').click({force: true})
  }

  fillFormUsingInvalidExpiration(){
    cy.get('.mat-radio-label-content').eq(1).click({force: true})
    cy.wait(2)
    cy.get('[data-test="input-card-number"]').type('4242424242424242', { force: true })
    cy.get('[data-test="input-holder-name"]').type('MemberSuite Test', { force: true })
    cy.get('[data-test="input-exp-month"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click({ force: true })
    cy.get('.mat-option-text').contains('01').click({ force: true })
    cy.get('[data-test="input-exp-year"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click({ force: true })
    cy.get('.mat-option-text').contains('24').click({ force: true })
    cy.get('[data-test="input-sec-code"]').type('123', { force: true })
    cy.get('[data-test="shipping-address-existing-0"] > .mat-radio-label > .mat-radio-container > .mat-radio-outer-circle').click({ force: true })
    cy.get('button').eq(2).should('have.text',' Checkout ').click({force: true})
  }

  fillFormUsingInvalidCard(){
    cy.get('.mat-radio-label-content').eq(1).click({force: true})
    cy.wait(2)
    cy.get('[data-test="input-card-number"]').type('4242424242424242ABC', { force: true })
    cy.get('[data-test="input-holder-name"]').type('MemberSuite Test', { force: true })
    cy.get('[data-test="input-exp-month"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click({ force: true })
    cy.get('#mat-option-4 > .mat-option-text').click({ force: true })
    cy.get('[data-test="input-exp-year"] > .mat-select-trigger > .mat-select-value > .mat-select-placeholder').click({ force: true })
    cy.get('#mat-option-19 > .mat-option-text').click({ force: true })
    cy.get('[data-test="input-sec-code"]').type('123', { force: true })
    cy.get('[data-test="shipping-address-existing-0"] > .mat-radio-label > .mat-radio-container > .mat-radio-outer-circle').click({ force: true })
    cy.get('button').eq(2).should('have.text',' Checkout ').click({force: true})
  }

  checkInvalidCardNumber(){
    cy.get('.mat-error').should('have.text',' Please enter a valid card number \\d* ')
  }

  checkPopUpFailedProcessing(){
    cy.get('.error-title.ng-star-inserted').should('be.visible')
  }

  checkThankYouPopUp(mail){
    cy.get('.title').should('have.text',' Thank you!  ')
    cy.get('.col-10 > .col-12').should('have.text',' Order Successful '+ mail + '  ')
    cy.wait(5000)
    cy.get('.buttons > .button').click()
  }

  checkThankYouPopUpWithoutMail(){
    cy.get('.title').should('have.text',' Thank you!  ')
    cy.get('.col-12 button.button-blue.ng-star-inserted').click()
  }

  checkSummary(productPrice,productTotal,taxPrice){
    cy.get('[data-test="product-name-0"]').should('have.text',' BluePay ')
    cy.get('.product-price').should('have.text',productPrice)
    cy.get('[data-test="product-total-0"]').should('have.text',productTotal)
    cy.get('[data-test="tax-price"]').should('have.text',taxPrice)
    cy.get('.total-price').eq(1).should('have.text',productTotal)
  }

  deleteSavedACH(){
    cy.get('[data-test-id="saved-payment-method-1"] > .col > a').click({force: true})
    cy.get('.buttons > .col-12').click()
  }

  checkShoppingCart(){
    cy.wait(3000)
    cy.get("body").then($body => {
      if ($body.find(".cart-items-indicator").length > 0) {   
        cy.wait(3000)
        cy.get('.icon-cart').click() 
        cy.wait(3000) 
        cy.get('.item-remove').click()
      } else {
        cy.get(':nth-child(1) > a > [data-test="community-tab"] > .inner-text').click()
      }
    });
  }
  
}

export default new ShopPage
