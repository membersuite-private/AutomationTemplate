@Smoke
@Subscriptions
Feature: Subscribe to a Publication

  @SubscriptionPayLater @Green @Purple @Production
  Scenario: In order to verify pay later Subscribe Publication

    When user should be able to login into users page
    Then user should be able to click shop
    And user should be able to subscribe to a publication
    Then user should be able to one of publications
    And user should be able to pay existing pay later payment and checkout
    Then a popup confirmation appear


  @SubscriptionCheckPayment @Green @Purple
  Scenario: In order to verify electronic check payment Subscribe Publication

    When user should be able to login into users page
    Then user should be able to click shop
    And user should be able to subscribe to a publication
    Then user should be able to one of publications
    And user should be able to pay existing electronic payment and checkout
    Then a popup confirmation appear

    @SubscribeNewPayment @Green @Purple
  Scenario: In order to verify new payment Subscribe Publication

    When user should be able to login into users page
    Then user should be able to click shop
    And user should be able to subscribe to a publication
    Then user should be able to one of publications
    And user should be able to pay new payment method and checkout

  @SubscriptionHistory @Green @Purple @Production
  Scenario: In order to verify view my subscriptions

    When user should be able to login into users page
    Then user should be able to click shop
    And user should be able to subscribe to a publication
    And user should be able to view my subscriptions

