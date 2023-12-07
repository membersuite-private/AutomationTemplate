import  HomePage  from '../pos/homepage'
import  LoginPage from '../pos/loginpage'
import  DonationsPage  from '../pos/donationspage'
import example from '../fixtures/example.json';
import ShopPage from '../pos/shoppage';

describe('Donations', () => {
  it('[PURPLE][GREEN][PRODUCTION] In order to verify view Donations page', () => {
    LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
    HomePage.clickDonations()
    HomePage.clickViewMyGivingDonations()
    DonationsPage.checkDonationsHistory()
  });

  it('[PURPLE][GREEN] In order to verify Making Donations', () => {
    LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
    HomePage.clickDonations()
    HomePage.clickMakingDonations()
    DonationsPage.clickFundraisingProduct01()
    DonationsPage.fillDonationForm()
    DonationsPage.clickContinue()
    DonationsPage.checkCheckoutPage()
    DonationsPage.donationSuccessfulPopUp()

  });

  it('[PURPLE][GREEN] In order to Making Donations as Organization', () => {
    LoginPage.doLogin(example.orgUser.email,example.orgUser.passwd)
    HomePage.changeToOrg()
    HomePage.clickDonations()
    HomePage.clickMakingDonations()
    DonationsPage.clickFundraisingProduct01()
    DonationsPage.fillDonationForm()
    DonationsPage.clickContinue()
    DonationsPage.checkCheckoutPage()
    DonationsPage.donationSuccessfulPopUp()

  });

  it('[PURPLE][GREEN] In order to not validate a expired card', () =>{
    LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
    HomePage.clickDonations()
    HomePage.clickMakingDonations()
    DonationsPage.clickFundraisingProduct01()
    DonationsPage.fillDonationFormExpiredCard()
    DonationsPage.checkCheckoutPage()
  })

  it('[PURPLE][GREEN] In order to validate if user can’t make a donation with a negative value', () =>{
    LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
    HomePage.clickDonations()
    HomePage.clickMakingDonations()
    DonationsPage.clickFundraisingProduct01()
    DonationsPage.fillValueWithNegativeValue()
    DonationsPage.fillDonationForm()
  })

  it('[PURPLE][GREEN] In order to validate if user can remove a donation from checkout', () =>{
    LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
    HomePage.clickDonations()
    HomePage.clickMakingDonations()
    DonationsPage.clickFundraisingProduct01()
    DonationsPage.closeForm()
  })

  it('[PURPLE][GREEN] In order to validate if user can list more than five donations on history table', () => {
    LoginPage.doLogin(example.realuser.email,example.realuser.passwd)
    HomePage.clickDonations()
    HomePage.clickViewMyGivingDonations()
    DonationsPage.checkDonationsHistory()
    DonationsPage.list10items()
    DonationsPage.list25items()
  });


});
