import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  DiscussionsPage  from '../pos/discussionspage'
import example from '../fixtures/example.json'

describe('Discussions', () => {
    beforeEach(() => {
        cy.on("uncaught:exception", (e, runnable) => {
            console.log("error", e);
            console.log("runnable", runnable);
            console.log("error", e.message);
            return false;
            });
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickCommunity()
        HomePage.clickDiscussions()
      });

    it('In order to verify view Discussion Board', () => {
        HomePage.clickViewDiscussionBoard()
        DiscussionsPage.checkDiscussionBoard()
        DiscussionsPage.clickWhatsColorIsTheBest()
        DiscussionsPage.checkDiscussionForum()

    })

    it('In order to verify view My Topic Subscriptions', () => {
        HomePage.clickViewMyTopicSubscriptions()
        DiscussionsPage.checkMyTopicSubscriptions()

    })

});