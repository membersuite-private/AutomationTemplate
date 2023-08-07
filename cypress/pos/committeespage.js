class CommitteesPage {
    checkBrowseAllCommitteespage(){
        cy.get("div").contains("Browse All Committees").should("be.visible")
        cy.get("input").invoke('attr', 'placeholder').should('eq', 'Name, Year...')
        cy.get("a").contains("View My Committees").should("be.visible")
        cy.get("a").contains("123 committee").should("be.visible")
        cy.get("a").contains("New testing committee").should("be.visible")
    }

    clickNewTestingcommittee(){
        cy.get("a").contains("New testing committee").click()
    }

    checkNewTestingcommitteeDetails(){
        cy.get("span").contains("New testing committee").should("be.visible")
        cy.get("b").contains("Committee Tasks :").should("be.visible")
        cy.get("a").contains("View Discussions").should("be.visible")
        cy.get("div").contains(" Join this Committee ").should("be.visible")
    }

    clickMyCommittees(){
        cy.get("a").contains("View My Committees").click()
    }

    checkMyCommitteesPage(){
        cy.get("span").contains("My Committees").should("be.visible")
        cy.get("div").contains("Current Committee Membership").should("be.visible")
        cy.get("div").contains("123 committee").should("be.visible")
    }

}

export default new CommitteesPage