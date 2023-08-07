import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  DiscussionsPage  from '../pos/discussionspage'
import  Utils from '../support/utils'

describe('Home Page loads when user opens application in browser', () => {
    beforeEach(() => {
        const credentials = {
            realuser: {
                email: 'testautomation@yoip.com',
                passwd: 'Password1!',
            },
        }
        LoginPage.navHere()
        LoginPage.acceptCookies()
        LoginPage.clickLogin()
        LoginPage.doLogin(credentials.realuser)
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