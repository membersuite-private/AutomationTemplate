class SignupPage{
  fillFirstPageForm(email){
    cy.xpath("//input[@formcontrolname='firstName']").type('Test')
    cy.xpath("//input[@formcontrolname='lastName']").type('Automation')
    cy.xpath("//input[@formcontrolname='email']").type(email)
    // cy.xpath("//input[@formcontrolname='password']").type('Password1!')
    cy.xpath("//button[@data-test-id='sign-up-button']").click()
  }

  fillCreateAccountWithoutFirstName(email){
    cy.xpath("//input[@formcontrolname='firstName']").clear()
    cy.xpath("//input[@formcontrolname='lastName']").type('Automation')
    cy.xpath("//input[@formcontrolname='email']").type(email)
    // cy.xpath("//input[@formcontrolname='password']").type('Password1!')
    cy.xpath("//button[@data-test-id='sign-up-button']").should('be.disabled')
    cy.xpath("//label[.=' cancel  First Name is required. ']").should('be.visible')
  }

  fillCreateAccountWithoutLastName(email){
    cy.xpath("//input[@formcontrolname='firstName']").type('Test')
    cy.xpath("//input[@formcontrolname='lastName']").clear()
    cy.xpath("//input[@formcontrolname='email']").type(email)
    // cy.xpath("//input[@formcontrolname='password']").type('Password1!')
    cy.xpath("//button[@data-test-id='sign-up-button']").should('be.disabled')
    cy.xpath("//label[.=' cancel  Last Name is required. ']").should('be.visible')
  }

  fillCreateAccountWithoutEmail(){
    cy.xpath("//input[@formcontrolname='firstName']").type('Test')
    cy.xpath("//input[@formcontrolname='lastName']").type('Automation')
    cy.xpath("//input[@formcontrolname='email']").clear()
    cy.xpath("//input[@formcontrolname='lastName']").click()
    // cy.xpath("//input[@formcontrolname='password']").type('Password1!')
    cy.xpath("//button[@data-test-id='sign-up-button']").should('be.disabled')
    cy.xpath("//label[.=' cancel  Email is required. ']").should('be.visible')
  }

  fillCreateAccountForm(){
    cy.xpath("//input[@formcontrolname='password']").type('Password1!')
    cy.get("[data-test='input-layout-type']").click({force: true})
    cy.xpath("//span[.= 'Individual Type 3']").click({force: true})
    // cy.xpath("//label[@for='phone-number-HomePhone-input']//div[@class='mat-radio-inner-circle']").click()
    cy.xpath("//button[.=' Next ']").click()
  }

  fillOrganizationFormWithoutOrganization(){
    cy.get('#mat-radio-11 > .mat-radio-label > .mat-radio-container > .mat-radio-outer-circle').click({force: true})
    cy.xpath("//button[.=' Next ']").click()
  }

  fillOrganizationFormWithOrganization(){
    cy.get('[data-test="input-selected-org"]').type('Purple Organization')
    cy.get('tr').click()
    cy.wait(2000)
    cy.get('.mat-select-placeholder').click()
    cy.get('.mat-option-text').contains(' Employee').click()
    cy.xpath("//button[.=' Next ']").click()
  }

  fillCommunicationPreferences(){
    cy.xpath("//button[.=' Next ']").click()
  }

  checkConfirmationPopUp(mail){
    cy.get('.col-8').should('have.text','Thank You!')
    cy.get('.account-created-info').should('have.text', ' Your account has been created. ')
    cy.get('.info-text').contains(mail)
    cy.get(':nth-child(1) > .button').should('be.visible')
    cy.get('[style=""] > .button').click()
  }




}

export default new SignupPage
