class EventsPage {
    
    checkEventsPage(){
        cy.get('div').contains('Events').should('be.visible')
        cy.get('div').contains('Grp Reg').should('be.visible')
        cy.get('div').contains('Music City Hall Event').should('be.visible')
    }

    clickOnGrpEvent(){
        cy.get('div').contains('Grp Reg').click()
    }

    checkEventDetails(){
        cy.get('div').contains('Grp Reg').should('be.visible')
        cy.get('div').contains('August 31 2017 12:00 AM - August 31 2050 12:00 AM').should('be.visible')
        cy.get('button').contains('Register').should('be.visible')
    }

    clickRegister(){
        cy.get('button').contains('Register').click()
    }

}

export default new EventsPage