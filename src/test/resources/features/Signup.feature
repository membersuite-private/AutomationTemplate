#language: en
#encoding: UTF-8
@TestAutomationDemo
Feature: Signup

  Background:
    Given are on the association's page

  @signup
  Scenario: Sign up new user
    And click on Login/Signup
    And click on Join
    And type "Levi" on First Name field
    And type "Santos" on Last Name field
    And type mail
    And type "Password1!" Password
    And click Signup
    Then Create account page appear
    And user select Individual Type 1 on type selection
    And user select Phone home on Phone Numbers and type "4045512121"
    And user select Home Address
    And user type "30" on Age field
    And click on Next
    Then Organization Information appear
    And user type "music city hall" on affiliated name
    And choose " Member Contact" on organization role
    And click on Next
    Then Communication Preferences appear
    And click on Next
    Then a confirmation screen appear


  @signup @error
  Scenario: Sign up without First Name
    And click on Login/Signup
    And click on Join
    And type "" on First Name field
    And type "Santos" on Last Name field
    And type mail
    And type "Password1!" Password
    Then First Name is required. message appear

  @signup @error
  Scenario: Sign up without Last Name
    And click on Login/Signup
    And click on Join
    And type "Levi" on First Name field
    And type "" on Last Name field
    And type mail
    And type "Password1!" Password
    Then Last Name is required. message appear

  @signup @error
  Scenario: Sign up without email
    And click on Login/Signup
    And click on Join
    And type "Levi" on First Name field
    And type "Santos" on Last Name field
    And don't type mail
    And type "Password1!" Password
    Then Email is required. message appear



