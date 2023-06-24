#language: en
#encoding: UTF-8
@TestAutomationDemo
Feature: Login

#  Background:
#    Given are on the application's page

  @login @validLogin
  Scenario: Login with valid username and password
    When user should be able to login into users page
    And main page appear

  @login @invalidLogin
  Scenario: Login with invalid username
    And type not valid Username
    And type Password field
    And click on LoginButton
    Then should appear "123Login credentials were invalid." message




