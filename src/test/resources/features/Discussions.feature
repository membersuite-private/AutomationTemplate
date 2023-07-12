#@Smoke
@Discussions
Feature: Discussions page
  In order to perform sucessful login
  As a user
  I should be able to login with correct credentials

  @DiscussionsBoard @Green @Purple @Production
  Scenario: In order to verify view Discussion Board

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click view Discussion Board on Discussions
    Then user should be able to verify view Discussion Board
    And user should be able to see one of the discussion boards

  @DiscussionsSubscriptions @Green @Purple @Production
  Scenario: In order to verify view my Topic Subscriptions

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click view my Topic Subscriptions
    Then user should be able to verify view my Topic Subscriptions
