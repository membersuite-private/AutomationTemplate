#@Smoke
@CareerCenter
Feature: Career Center page
  In order to perform sucessful login
  As a user
  I should be able to login with correct credentials

  @CareerCenterFindJob @Green @Purple @Production
  Scenario: In order to verify find job on Career Center page

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click Career Center
    Then user should be able to click on find a job
#    And user should be able to select IT and apply for search
    Then user should be able to apply one of the job post


  @CareerCenterViewEmployers @Green @Purple @Production
  Scenario: In order to verify view Employers page

    When user should be able to login into users page
    Then user should be able to click community
    And user should be able to click Career Center
    Then user should be able to click on Employers and search resumes on Employers
    And user should be able to see Resume results