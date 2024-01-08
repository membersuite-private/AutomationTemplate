class ApiCalls {

    goToMyAccount(){
      cy.visit('/profile')
    }

    DeleteUser(){
      cy.fixture('properties').then((properties)  => {
        let email = properties.email
        cy.GetTokenAuthentication(email)
        cy.GetOwnerId()
        cy.DeleteRequest()
      })
    }
}

export default new ApiCalls