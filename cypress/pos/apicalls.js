class ApiCalls {

    goToMyAccount(){
      cy.visit('/profile')
    }

    DeleteUser(environment){
      cy.fixture('properties').then((properties)  => {
        let email = properties.email
        cy.GetTokenAuthentication(email,environment)
        cy.GetOwnerId(environment)
        cy.DeleteRequest(email,environment)
      })
    }
}

export default new ApiCalls