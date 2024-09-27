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


