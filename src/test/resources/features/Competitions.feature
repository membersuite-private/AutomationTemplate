#@Smoke
@Competitions
Feature: Competitions page
  In order to perform sucessful login
  As a user
  I should be able to login with correct credentials

  @Green @Purple @Production
  Scenario: In order to view open competitions page

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click view competitions on competitions
    Then user should be able to choose competition type on view competitions
    And user should be able to select one of competitions
    Then user should be able to enter and arrange entry fee
    And user should be able to fill out information and save as draft on competition

  @CompetitionsView @Green @Purple @Production
  Scenario: In order to view  my competition entries page

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click view my competitions on competitions
    Then user should be able to see one of the competitions

  @Green @Purple @Production
  Scenario: In order to view  judging center page

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click judging center on competitions
    Then user should be able to see one of the judgin bucket




