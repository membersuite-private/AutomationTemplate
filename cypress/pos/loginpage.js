// LoginPage Class
import example from '../fixtures/example.json';
import  HomePage  from '../pos/homepage'

class LoginPage {
    navHere() {
      // return cy.visit('/auth/portal-login');
      return cy.visit('/home');
    }

    navHome(){
      cy.visit('/home');
    }

    checkTitlesAndFields() {
      const fhelem = 'label';
      const fgelem = 'div.form-group';
      const sbelem = 'button[type="submit"]';
      const fgtext = 'Username';
      const fhtext = 'Sign in with your email and password';
      return (
        cy.contains(fhelem, fhtext) &&
        cy.contains(fgelem, fgtext) &&
        cy.contains(fgelem, 'Password') &&
        cy.contains(sbelem, 'Sign In')
      );
    }

    fillEmail() {
      return cy.get('input[type="text"]').type(example.realuser.email);
    }

    fillPassword() {

      return cy.get('input[type="password"]').type(example.realuser.passwd);
    }

    submitLoginForm() {
      return cy.get('button[type=submit]').click();
    }

    tryLogin(form) {
      const errelem = 'p.has-error';
      const errmessage = 'User not found';
      this.fillEmail(form.email);
      this.fillPassword(form.passwd);
      this.submitLoginForm();
      return cy.contains(errelem, errmessage) && cy.url().should('include', '/auth/portal-login');
    }

    doLogin(form) {
      this.navHere()
      this.acceptCookies()
      this.clickLogin()
      this.fillEmail();
      this.fillPassword();
      this.submitLoginForm();
      HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
      return cy.url().should('include', '/auth/login');
    }

    checkInvalidPassword(){
      this.navHere()
      this.acceptCookies()
      this.clickLogin()
      cy.get('input[type="text"]').type(example.realuser.email);
      cy.get('input[type="password"]').type('FakePassword');
      this.submitLoginForm();
      cy.get('.has-error').should('have.text','Login credentials were invalid.')
    }

    checkInvalidUsername(){
      this.navHere()
      this.acceptCookies()
      this.clickLogin()
      cy.get('input[type="text"]').type('testautomation123@yoip.com');
      cy.get('input[type="password"]').type(example.realuser.passwd);
      this.submitLoginForm();
      cy.get('.has-error').should('have.text','User not found')
    }

    checkInvalidUsernamePassword(){
      this.navHere()
      this.acceptCookies()
      this.clickLogin()
      cy.get('input[type="text"]').type('testautomation123@yoip.com');
      cy.get('input[type="password"]').type('FakePassword');
      this.submitLoginForm();
      cy.get('.has-error').should('have.text','User not found')
    }

    acceptCookies(){
      return cy.get('.cc-btn').click();
    }

    clickLogin(){
        cy.get('.profile-text').click()
        cy.get('[data-test="menu-login"]').click()
    }

    clickSignup(){
      cy.get('.profile-text').click()
        cy.get('[data-test="menu-join"]').click()
    }

    goToProfile(){
      cy.visit('https://purplepps.users.purple.membersuite.com/profile')
    }
  }
  export default new LoginPage
