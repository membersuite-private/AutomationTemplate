class CommitteesPage {
    checkBrowseAllCommitteespage(){
        cy.get("div").contains("Browse All Committees").should("be.visible")
        cy.get("input").invoke('attr', 'placeholder').should('eq', 'Name, Year...')
        cy.get("a").contains("View My Committees").should("be.visible")
        cy.get("a").contains("123 committee").should("be.visible")
        cy.get("a").contains("New testing committee").should("be.visible")
    }

    click123Committee(){
        cy.get('div').contains('123 committee').click()
    }

    clickAnotherCommittee(){
        cy.get('div').contains('Another Committee').click()
    }

    clickNewTestingcommittee(){
        cy.get("a").contains("New testing committee").click()
    }

    clickRemoveMySelf(){
        cy.get('div').contains('Remove Myself from this Committee').click()
        cy.get('button').contains(' Confirm ').click()
    }

    clickJoinThisCommittee(){
        cy.get('div').contains('Join this Committee').click()
        cy.get('button').contains(' Confirm ').click()
    }

    checkNewTestingcommitteeDetails(){
        cy.get("span").contains("New testing committee").should("be.visible")
        cy.get("b").contains("Committee Tasks :").should("be.visible")
        cy.get("a").contains("View Discussions").should("be.visible")
        cy.get('div.ng-star-inserted').contains("Join this Committee").should("be.visible")
    }

    clickMyCommittees(){
        cy.get("a").contains("View My Committees").click()
    }

    checkMyCommitteesPage(){
        cy.get("span").contains("My Committees").should("be.visible")
        cy.get("div").contains("Current Committee Membership").should("be.visible")
        cy.get("div").contains("123 committee").should("be.visible")
    }

    searchCommittee(){
        cy.get('mat-cell').contains('Music City Hall').should('be.visible')
        cy.get('#mat-input-0').type('Test Automation')
        cy.wait(5000)
        cy.get('.mat-paginator-range-label').should('have.text','1 – 1 of 1')
    }

    clickExport(){
        cy.get('div').contains('Export List').click()
    }
    
    checkDownload(){
        cy.readFile('cypress/downloads/123committeeroster.xlsx')
    }

    typeSearchCommittee(){
        cy.get('input').type('New testing committee').type('{enter}')
        cy.get("[data-test='committee-name']").should('have.length',1)
    }

}

export default new CommitteesPage