#language: en
#encoding: UTF-8
@TestAutomationDemo
Feature: Login

  Background:
    Given are on the application's page

  @login
  Scenario: Login with valid username and password
    And type Username field
    And type Password field
    And click on LoginButton
    And main page appear

  @login
  Scenario: Login with invalid username
    And type not valid Username
    And type Password field
    And click on LoginButton
    Then should appear "123Login credentials were invalid." message




