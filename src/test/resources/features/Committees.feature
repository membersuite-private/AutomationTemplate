#@Smoke
@Committees
Feature: Committees page
  In order to perform sucessful login
  As a user
  I should be able to login with correct credentials

  Scenario: In order to verify browse Committees page

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click committees
    And user should be able to click browse committees
    Then user should be able to verify one of the committees

  @CommitteesVerifyMyCommittees
  Scenario: In order to verify view my Committees page

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click browse committees
    Then user should be able to click my committees
    And user should be able to verify one of the my committees


