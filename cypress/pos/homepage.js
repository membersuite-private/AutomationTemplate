class HomePage {

    clickAllowCoockies(){
        cy.get('.cc-btn').click()
    }

    clickLogin(){
        cy.get('span').eq(6).click()
        cy.get('[data-test="menu-login"]').eq(1).click()
    }

    fillEmail(){
        cy.get('input').eq(0).type('testautomation@yoip.com')
    }

    fillPassword(){
        cy.get('input').eq(1).type('Password1!')
    }

    clickSignIn(){
        cy.get('button').click()
    }

    navHere() {
        return cy.visit('/home');
      }

      checkProfileIcon(label) {
        const elem = '.profile-text';
        return cy.contains(elem, label);
      }

      clickProfileIcon(label, options) {
        const elem = '.profile-text';
        cy.contains(elem, label).click();
        return (
          cy.get('[data-test="user-dropdown"]').should('be.visible')
          && cy.get('[data-test="menu-login"]').should('be.visible')
          && cy.get('[data-test="menu-join"]').should('be.visible')
        );
      }

      checkGreeting(label) {
        const elem = '.centered-text > h1:nth-child(1)';
        return cy.contains(elem, label);
      }

      checkHomeNav(links) {
        links.forEach((link) => {
          const elem = 'li.item > a';
          return cy.contains(elem, link);
        });
      }

      checkFeatured(label) {
        const elem = 'div.featured > section > .card-tile > .tile-title > .pointer';
        return cy.contains(elem, label);
      }

      checkEventsYouLike(label) {
        const elem = 'div.noFeature > section.events-may-like';
        return cy.contains(elem, label);
      }

      checkHomepage(){
        cy.get('span').contains('Home').should('be.visible')
        cy.get('span').contains('Community').should('be.visible')
        cy.get('span').contains('Events').should('be.visible')
        cy.get('span').contains('Shop').should('be.visible')
        cy.get('span').contains('Donations').should('be.visible')
        cy.get('span').contains('Certifications').should('be.visible')
      }

      clickCommunity(){
        cy.get('span').contains('Community').click()
      }

      clickCarrerCenter(){
        cy.get('div').contains('Career Center').click()
        cy.wait(3)
      }

      clickCommittees(){
        cy.get(':nth-child(3) > .nav-modal-link-bar > .nav-modal-link').click()
      }

      clickCompetitions(){
        cy.get('div').contains('Competitions').click()
        cy.wait(3)
      }

      clickViewOpenCompetiotions(){
        cy.get('div').contains('View Open Competitions').click()
        cy.wait(3)
      }

      clickViewMyCompetiotionsEntries(){
        cy.get('div').contains('View My Competition Entries').click()
        cy.wait(3)
      }

      clickJudgingCenter(){
        cy.get('div').contains('Judging Center').click()
        cy.wait(3)
      }

      clickBrowseCommittees(){
        cy.get(':nth-child(2) > .nav-modal-link').click()
        cy.wait(3)
      }

      clickEvents(){
        // cy.get(':nth-child(3) > a > [data-test="community-tab"] > .inner-text').click()
        cy.get('.inner-text').eq(2).click()
        // cy.get('div').contains('Browse Events').click()
      }

      clickMyEvents(){
        this.clickEvents()
        cy.get(':nth-child(2) > .nav-modal-link-bar > .nav-modal-link').click()
        cy.wait(3)
      }

      clickMyExhibits (){
        cy.visit('/events/myExhibits')
        cy.get('h2').should('have.text','My Exhibits').click()
        cy.wait(3)
      }

      clickDonations(){
        cy.get(':nth-child(5) > a > [data-test="community-tab"] > .inner-text').click()
      }

      clickViewMyGivingDonations(){
        cy.wait(2)
        cy.get('[class*="nav-modal-link"]').eq(3).click()
      }

      clickMakingDonations(){
        cy.wait(2)
        cy.get('[class*="nav-modal-link"]').eq(1).click()
      }

      checkUserProfile(){
        cy.get("span").contains("Hi, Test Automat...").should("be.visible")
      }

      clickDiscussions(){
        cy.get('div').contains('Discussions').click()
        cy.wait(3)
      }

      clickViewDiscussionBoard(){
        cy.get('div').contains('View Discussion Board').click()
        cy.wait(3)
      }

      clickViewMyTopicSubscriptions(){
        cy.get('div').contains('View My Topic Subscriptions').click()
        cy.wait(3)
      }

      clickShop(){
        cy.get(':nth-child(4) > a > [data-test="community-tab"] > .inner-text').click()
      }

      clickSubscribetoaPublication(){
        cy.get(':nth-child(2) > .nav-modal-link-bar > .nav-modal-link').click()
        cy.get(':nth-child(1) > .nav-modal-link').click()
      }

      clickViewSubscription(){
        cy.get(':nth-child(2) > .nav-modal-link-bar > .nav-modal-link').click()
        cy.get(':nth-child(2) > .nav-modal-link').click()
      }

      clickBrowseShop(){
        cy.get(':nth-child(1) > .nav-modal-link-bar > .nav-modal-link').click()
      }

      clickNotifications(){
        cy.get('[ng-reflect-ng-class="fa-lg"]').click()
      }

}
export default new HomePage