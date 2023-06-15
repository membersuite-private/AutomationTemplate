#@Smoke
@Events
Feature: Events Page

  Scenario: In order to verify Individual Event registration

    When user should be able to login into users page
    Then user should be able to click events on main page
    And user should be able to register two new individual

  Scenario: In order to verify my Event Registrations

    When user should be able to login into users page
    Then user should be able to click events on main page
    And user should be able to click my events on Events

  Scenario: In order to verify my Exhibits

    When user should be able to login into users page
    Then user should be able to click events on main page
    And user should be able to click my exhibits on Events