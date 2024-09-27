Feature: Login

In order to manage the employee records
As a admin
I would like to access orange hrm portal.

Scenario: ValidLogin
Given I have browser with OrangeHRM application
When I enter username as 'Admin'
And I enter password as 'admin123'
And I click on login
Then I should get access to dashboard page with 'Quick Launch'

Scenario: InvalidLogin
Given I have browser with OrangeHRM application
When I enter username as 'john'
And I enter password as 'john123'
And I click on login
Then I should not get access to dashboard with error as 'Invalid crendentials'




