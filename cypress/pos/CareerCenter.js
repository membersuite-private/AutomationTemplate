class CareerCenter {
    
    checkCarrerPage(){
        cy.get('h4').contains('Search Job Listings').should('be.visible')
        cy.get('div').contains('Find a Job').should('be.visible')
        cy.get('div').contains('Employers').should('be.visible')
    }



    clickEmployersTab(){
        cy.get('div').contains('Employers').click()
        cy.get('h4').contains('Search Resumes').should('be.visible')
        cy.get('.search-input').should('be.visible')
    }

    clickSearch(){
        cy.get('button').contains('Search').click()
    }

    click130pm(){
        cy.get('h3').contains('130 pm').click()
    }

    view130pmDetails(){
        cy.get('h4').contains('130 pm').should('be.visible')
        cy.get('span').contains('abcdefg').should('be.visible')
        cy.get('p').contains('Company 1').should('be.visible')
        cy.get('div').contains(' June 26, 2023').should('be.visible')
    }

    showSearchResume(){
        cy.get('h4').contains('Career Center - Resume Results').should('be.visible')
        cy.get('div').contains('No Resumes Found').should('be.visible')
        cy.get('span').contains('Clear All').should('be.visible')
        cy.get('span').contains('Apply').should('be.visible')
    }

}

export default CareerCenter