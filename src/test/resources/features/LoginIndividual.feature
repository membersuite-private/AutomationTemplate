#@Smoke
@LoginIndividualPositive @Green @Purple @Production
Feature: Login Individual
  In order to perform sucessful login
  As a user
  I should be able to login with correct credentials

  Background:
    Given are on the application's page

  Scenario: In order to verify Login Functionality

    When user should be able to login into users page

  Scenario: In order to verify invalid password

    When user should be able to login into users page with invalid individual password

  Scenario: In order to verify invalid username

    When user should be able to login into users page with invalid individual username

  Scenario: In order to verify invalid username and password

    When user should be able to login into users page with invalid username and password




