Feature: Employee

In order to manage the employee records
As a admin
I want to add, edit and delete the employee records

Scenario Outline: AddValidEmployeeRecord
Given I have browser with OrangeHRM application
When I enter username as '<username'
And I enter password as '<password>'
And I click on login
And I click on PIM menu
And I click on Add Employee menu
And I fill the new employee details
| firstname | middlename | lastname |
| <fname>      | <middlename>          | <lname>     |
And I click on save
Then I should see the profile name as '<fname> <lname>'
And I should verify the employee full name in the text field
Examples: 
| username | password | fname | middlename | lname |
| Admin    | admin123 | john  | w          | wick  |
| peter    | admin123 | peter | k          | kevin |

