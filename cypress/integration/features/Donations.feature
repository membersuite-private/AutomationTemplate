#@Smoke
@Donation
Feature: Donations page
  In order to perform sucessful login
  As a user
  I should be able to login with correct credentials

  # @Green @Purple
  # Scenario: In order to verify Donations page

  #   When user should be able to login into users page
  #   Then user should be able to click make donation
  #   And user should be able to choose donation fund
  #   Then user should be able to fill out address and payment for fund
  #   And user should be able to get successful donation message

  @Green @Purple @Production
  Scenario: In order to verify view Donations page

    When user should be able to login into users page
    Then user should be able to click view my giving history
    And user should be able to see giving history elements
    Then user should be able to change sorting on giving history


