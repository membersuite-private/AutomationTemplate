@Smoke
@Shop
Feature: Shop a Merchandising

  @Green @Purple
  Scenario: In order to verify electronic check payment in Shop Cart
    When user should be able to login into users page
    Then user should be able to click shop
    And user should be able to click Browse
    And user should be able to pay for a product using an existing electronic payment and checkout
    Then a Thank You message appear

  Scenario: In order to verify new payment Subscribe Publication
    When user should be able to login into users page
    Then user should be able to click shop
    And user should be able to click Browse
    And user should be able to pay for a product using a new electronic payment and checkout
    Then a Thank You message appear