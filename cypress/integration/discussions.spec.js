import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  DiscussionsPage  from '../pos/discussionspage'
import example from '../fixtures/example.json'

describe('Discussions', () => {
    beforeEach(() => {
        LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
        HomePage.clickCommunity()
        HomePage.clickDiscussions()
      });

    it('[PURPLE][GREEN][PRODUCTION] In order to verify view Discussion Board', () => {
        HomePage.clickViewDiscussionBoard()
        DiscussionsPage.checkDiscussionBoard()
        DiscussionsPage.clickWhatsColorIsTheBest()
        DiscussionsPage.checkDiscussionForum()

    })

    it('[PURPLE][GREEN][PRODUCTION] In order to verify view My Topic Subscriptions', () => {
        HomePage.clickViewMyTopicSubscriptions()
        DiscussionsPage.checkMyTopicSubscriptions()

    })

});