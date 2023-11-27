class CompetitionsPage{
  checkBrowseCompetitionsPage(){
      cy.get("div").contains("Browse Competitions").should("be.visible")
  }

  clickTumonat10competition(){
      cy.get("a").contains(" Tum on at 10 competition ").click()
  }

  checkTumonat10competitionDetail(){
      cy.get("h4").contains("Tum on at 10 competition").should("be.visible")
      cy.get("button").contains("Enter Now").should("be.visible")
      cy.get("div").contains(" June 01, 2023 ").should("be.visible")
      cy.get("div").contains(" September 29, 2028 ").should("be.visible")
      cy.get("div").contains("/ 999").should("be.visible")
  }

  clickEnterNow(){
      cy.get("button").contains("Enter Now").click()
  }

  tumonat10competitionFormInformation(){
      cy.get("h3").contains("Tum on at 10 competition - Form Information").should("be.visible")
      cy.get("input").should('have.length',2)
      cy.get("button").contains("Save As Draft").should("be.visible")
  }

  clickSaveasDraft(){
      cy.get("button").contains("Save As Draft").click()
  }

  popUpCompetitionEntry(){
      cy.get("h3").contains("Competition Entry Confirmation").should("be.visible")
      cy.get("span").contains("Your entry has been saved successfully.").should("be.visible")
      cy.get("span").contains("How would you like to continue?").should("be.visible")
      cy.get("button").contains("Back to Entry").should("be.visible")
      cy.get("button").contains("Go Home").should("be.visible")
  }

  clickGoHome(){
      cy.get("button").contains("Go Home").click()
  }

  checkMyCompetitionEntriesPage(){
      cy.wait(20000)
      cy.get("mat-card-title").contains("My Competition Entries").should("be.visible")
      cy.get("div").contains("My Competition Entries Tasks").should("be.visible")
      cy.get("a").contains("Browse Competitions").should("be.visible")
      cy.get("mat-row").should("have.length",5)
  }

  checkJudgeCenterPage(){
      cy.get("h2").contains("Judging Center").should("be.visible")
      cy.get("h4").contains("Access all entries that have been assigned to you for judging.").should("be.visible")
      cy.get("div").contains("Tum on at 10 competition").should("be.visible")
  }

  clickFilterCompetitionType(){
    cy.get(".mat-select-placeholder.ng-tns-c86-5").click({force: true})
    cy.get(".mat-select-placeholder.ng-tns-c86-5").type('{downArrow}')
    cy.get('.mat-accordion > .filters > .mat-form-field > .mat-form-field-wrapper > .mat-form-field-flex > .mat-form-field-infix > [data-test="input-competitions-type"] > .mat-select-trigger > .mat-select-value').click()
    cy.get('.mat-option-text').contains(' Competition Type 1 ').click()
  }

  clickContinueDraft(){
    cy.get('.my-competition-action').contains('Continue ').click()
    cy.get('button').contains('Next').click()
    cy.get('button').contains('Submit').click()
  }

  sortByStatus(){
    cy.get('button').contains(' Status ').click()
  }

  checkCompetitionEntryConfirmation(){
    cy.wait(5000)
    cy.get('h3').should('have.text','Competition Entry Confirmation')
    cy.get('.body-message').should('have.text',' Your entry has successfully been submitted.')
    cy.get('.main-button > .button').should('be.visible')
    cy.get('.remove-space > .button').should('be.visible')
  }

  clickViewEntry(score){
    cy.get('span').contains('View Entry').click()
    cy.get('a').contains(' Edit Scores ').click()
    cy.get('#mat-input-2').type('{backspace}')
    cy.get('#mat-input-2').type('{backspace}')
    cy.get('#mat-input-2').type(score)
    cy.get('button').contains('Submit').click()
  }

  checkJudgingRound(score){
    cy.get('.table-cell-score').should('have.text',' '+ score +' ')
  }

}

export default new CompetitionsPage
