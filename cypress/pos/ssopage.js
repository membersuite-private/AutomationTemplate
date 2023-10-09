class SSOPage{
    checkBrowseShopPage(){
      cy.get('[data-test="store-search"]').should('be.visible')
      cy.get('[data-test="product-name"]').eq(5).should('have.text','BluePay')
    }

    visitSSOPage(){
        cy.visit('https://customer35735f2cc.portal-purple.financial.membersuite.com/Login.aspx')
        this.allowCookie()
    }

    fillform(email){
        cy.get('#PageContent_tbEmail').type(email)
        cy.get('#PageContent_tbPassword').type('Password1!')
        cy.get('#PageContent_btnLogin').click()
    }

    checkValues(email){
        cy.get('#PageContent_ucMyProfile1_hlEmail').should('have.text', email)
    }

    allowCookie(){
        cy.get('.cc-btn').click()
    }
    
  }
  
  export default new SSOPage
  