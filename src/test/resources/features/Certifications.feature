#@Smoke
@Certifications
Feature: Competitions page
#  In order to perform sucessful login
#  As a user
#  I should be able to login with correct credentials

  Scenario: In order to view My CEU Credit History

    When user should be able to login into users page
    Then user should be able to click Certifications
    And user should be able to click and see My CEU Credit History

  Scenario: In order to view Report Edit Ceu Credits
    When user should be able to login into users page
    And user should be able to click Certifications
    And user should be able to click and see Report Edit CEU Credits


  Scenario: In order to view view Renew My Certifications

    Then user should be able to click Certifications
    And user should be able to click and see view Renew my Certifications

  Scenario: In order to view Report Component Attendance

    When user should be able to login into users page
    Then user should be able to click Certifications
    And user should be able to click and see Report Component Attendance

  Scenario: In order to View My Certification Components

    When user should be able to login into users page
    Then user should be able to click Certifications
    And user should be able to click and see View My Certification Components

  Scenario: In order to View Apply for Certification

    When user should be able to login into users page
    Then user should be able to click Certifications
    And user should be able to click and see Apply for Certification

  Scenario: In order to View Certification Application History

    When user should be able to login into users page
    Then user should be able to click Certifications
    And user should be able to click and see View Certification Application History