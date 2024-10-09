using EmployeeManagementAutomation.Hooks;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class EmplyeeStepDefinition
    {
        private AutomationHooks hooks;
        public EmplyeeStepDefinition(AutomationHooks hooks)
        {
            this.hooks = hooks;
        }

        [When(@"I click on PIM menu")]
        public void WhenIClickOnPIMMenu()
        {
            hooks.driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            
        }

        [When(@"I click on Add Employee menu")]
        public void WhenIClickOnAddEmployeeMenu()
        {
            hooks.driver.FindElement(By.XPath("//button[normalize-space()='Add']")).Click();
        }

        [When(@"I fill the new employee details")]
        public void WhenIFillTheNewEmployeeDetails(Table table)
        {
            //Console.WriteLine(table.Rows[0][0]);
            //Console.WriteLine(table.Rows[0][1]);

            //Console.WriteLine(table.Rows[0]["firstname"]);
            //Console.WriteLine(table.Rows[0]["middlename"]);
            //Console.WriteLine(table.Rows[0]["lastname"]);

            hooks.driver.FindElement(By.Name("firstName")).SendKeys(table.Rows[0]["firstname"]);
            hooks.driver.FindElement(By.Name("middleName")).SendKeys(table.Rows[0]["middlename"]);
            hooks.driver.FindElement(By.Name("lastName")).SendKeys(table.Rows[0]["lastname"]);
        }

        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
            hooks.driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
        }

        [Then(@"I should see the profile name as '(.*)'")]
        public void ThenIShouldSeeTheProfileNameAs(string p0)
        {
            
        }

        [Then(@"I should verify the employee full name in the text field")]
        public void ThenIShouldVerifyTheEmployeeFullNameInTheTextField()
        {
            
        }
    }
}
