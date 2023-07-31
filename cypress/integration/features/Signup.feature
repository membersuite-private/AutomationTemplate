#language: en
#encoding: UTF-8
@Signup
Feature: Signup

  Background:
    Given are on the association's page

  @signupNewUser @Green @Purple @Production
  Scenario: Sign up new user affiliated to a Organization
    And click on Login/Signup
    And click on Join
    And type "Levi" on First Name field
    And type "Santos" on Last Name field
    And type mail
    And type "Password1!" Password
    And click Signup
    Then Create account page appear
    And user select Individual Type 3 on type selection
    And user select Phone home on Phone Numbers and type "4045512121"
    And user select Home Address
    And click on Next
    Then Organization Information appear
    And user type "Purple Organization" on affiliated name
    And choose " Member Contact" on organization role
    And click on Next
    Then Communication Preferences appear
    And click on Next
    Then a confirmation screen appear

  @signupNewUserNotAffiliated @Green @Purple @Production
  Scenario: Sign up new user  not affiliated to a Organization
    And click on Login/Signup
    And click on Join
    And type "Levi" on First Name field
    And type "Santos" on Last Name field
    And type mail
    And type "Password1!" Password
    And click Signup
    Then Create account page appear
    And user select Individual Type 3 on type selection
    And user select Phone home on Phone Numbers and type "4045512121"
    And user select Home Address
    And click on Next
    Then Organization Information appear
    And user select not affiliated with an Organization
    And click on Next
    Then Communication Preferences appear
    And click on Next
    Then a confirmation screen appear without Organization Membership

  @signup @error @Green @Purple @Production
  Scenario: Sign up without First Name
    And click on Login/Signup
    And click on Join
    And type "" on First Name field
    And type "Santos" on Last Name field
    And type mail
    And type "Password1!" Password
    Then First Name is required. message appear

  @signup @error @Green @Purple @Production
  Scenario: Sign up without Last Name
    And click on Login/Signup
    And click on Join
    And type "Levi" on First Name field
    And type "" on Last Name field
    And type mail
    And type "Password1!" Password
    Then Last Name is required. message appear

  @signup @error @Green @Purple @Production
  Scenario: Sign up without email
    And click on Login/Signup
    And click on Join
    And type "Levi" on First Name field
    And type "Santos" on Last Name field
    And don't type mail
    And type "Password1!" Password
    Then Email is required. message appear



