class HomePage {

    clickAllowCoockies(){
        cy.get('.cc-btn').click()
    }

    clickLogin(){
        // cy.get('span').eq(6).click()
        // cy.get('[data-test="menu-login"]').eq(1).click()
        cy.visit('/auth/portal-login')
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

      clickCommunity(){
        cy.get('span').contains('Community').click()
      }

      clickCertifications(){
        cy.get('span').contains('Certifications').click()
      }

      clickCarrerCenter(){
        cy.visit('/community/career-center/gateway')
      }

      clickViewMyCreditHistory(){
        cy.visit('/certification/credits-list')
      }

      clickReportCEUCredits(){
        cy.visit('/certification/credits-list/create-ceu-report')
      }

      clickCommittees(){
        cy.get(':nth-child(3) > .nav-modal-link-bar > .fa').as('moreCommittees')
        cy.get('@moreCommittees').should('be.visible')
        cy.get(':nth-child(3) > .nav-modal-link-bar > .nav-modal-link').click()
      }

      clickCompetitions(){
        cy.get('div').contains('Competitions').click()
        cy.get(':nth-child(1) > .nav-modal-link').should('be.visible')
        cy.get(':nth-child(2) > .nav-modal-link').should('be.visible')
        cy.get(':nth-child(3) > .nav-modal-link').should('be.visible')
        cy.wait(3000)
      }

      clickViewOpenCompetiotions(){
        cy.get('.nav-modal-link').contains('View Open Competitions').click()
        cy.url().should('include', '/community/competitions/browse')
        // cy.visit('/community/competitions/browse')
      }

      clickViewMyCompetiotionsEntries(){
        cy.get('.nav-modal-link').contains('View My Competition Entries').click()
        // cy.visit('/community/competitions/my-competition-registration')
      }

      clickJudgingCenter(){
        // cy.get('.nav-modal-link').contains('Judging Center').click()
        // cy.url().should('include', '/community/competitions/judging-center')
        cy.visit('/community/competitions/judging-center')
      }

      clickBrowseCommittees(){
        cy.visit('/community/committee/committee-browse')
      }

      clickViewMyCommittees(){
        cy.visit('/community/committee/my-committee')
      }

      clickEvents(){
        cy.visit('/events/browse')
      }

      clickMyEvents(){
        cy.visit('/events/myEventRegistration')
        cy.wait(3)
      }

      clickMyExhibits (){
        cy.visit('/events/myExhibits')
        cy.get('h2').should('have.text','My Exhibits').click()
        cy.wait(3)
      }

      clickDonations(){
        cy.wait(3000)
        cy.get(':nth-child(5) > a > [data-test="community-tab"] > .inner-text').click()
      }

      clickViewMyGivingDonations(){
        // cy.wait(2)
        // cy.get('[class*="nav-modal-link"]').eq(3).click()
        cy.visit('/donations/donations-history')
      }

      clickMakingDonations(){
        // cy.wait(2)
        // cy.get('[class*="nav-modal-link"]').eq(1).click()
        cy.visit('/donations/donations-workflow')
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
        cy.get('span').contains('Shop').click()
      }

      clickSubscribetoaPublication(){
        cy.get(':nth-child(2) > .nav-modal-link-bar > .nav-modal-link').click()
        cy.get(':nth-child(1) > .nav-modal-link').click()
      }

      clickViewSubscription(){
        cy.wait(5000)
        cy.visit('/shop/subscriptions/history')
      }

      clickBrowseShop(){
        // cy.get(':nth-child(1) > .nav-modal-link-bar > .nav-modal-link').click()
        cy.visit('/shop/store/browse')
      }

      clickNotifications(){
        cy.get('[ng-reflect-ng-class="fa-lg"]').click()
      }

      changeToOrg(){
        cy.get('.switch-profile-user-image.ng-star-inserted').eq(1).click({force: true})
        cy.get('[data-test="profile-icon"]').click()
        cy.get('[data-test="menu-join"]').should('be.visible')
        cy.wait(3000)
        cy.get('.switch-profile-user-name').contains('Music City Hall').click({force: true})
        
      }

}
export default new HomePage
