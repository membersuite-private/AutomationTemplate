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
      cy.get("div").contains("1 / 999").should("be.visible")
  }

  clickEnterNow(){
      cy.get("button").contains("Enter Now").click()
  }

  tumonat10competitionFormInformation(){
      cy.get("h3").contains("Tum on at 10 competition - Form Information").should("be.visible")
      // cy.get("div").contains("Entry Form").should("be.visible")
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

}

export default new CompetitionsPage
