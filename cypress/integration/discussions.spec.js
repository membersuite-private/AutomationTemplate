import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  DiscussionsPage  from '../pos/discussionspage'
import  Utils from '../support/utils'

describe('Discussions', () => {
    beforeEach(() => {
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin()
        HomePage.checkHomeNav(['Home', 'Community', 'Events', 'Shop', 'Donations', 'Certifications'])
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