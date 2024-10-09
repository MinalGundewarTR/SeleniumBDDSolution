using EmployeeManagementAutomation.Hooks;
using EmployeeManagementAutomation.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class EmplyeeStepDefinition
    {
        private MainPage main;
        private PIMPage pimPage;
        private AddEmployeePage addEmployeePage;
        //private PersonalDetailPage personalDetailPage;

        private AutomationHooks hooks;
        public EmplyeeStepDefinition(AutomationHooks hooks)
        {
            this.hooks = hooks;
            InitPageObject();
        }
        public void InitPageObject()
        {
            main = new MainPage(hooks.driver);
            pimPage = new PIMPage(hooks.driver);
            addEmployeePage = new AddEmployeePage(hooks.driver);
            //personalDetailPage = new PersonalDetailPage(hooks.driver);
        }


        [When(@"I click on PIM menu")]
        public void WhenIClickOnPIMMenu()
        {
            main.ClickOnPIMMenu();
            
        }

        [When(@"I click on Add Employee menu")]
        public void WhenIClickOnAddEmployeeMenu()
        {
            //hooks.driver.FindElement(By.XPath("//button[normalize-space()='Add']")).Click();
            pimPage.ClickOnAddEmployeeMenu();
        }

        [When(@"I fill the new employee details")]
        public void WhenIFillTheNewEmployeeDetails(Table table)
        {
            //Console.WriteLine(table.Rows[0][0]);
            //Console.WriteLine(table.Rows[0][1]);

            //Console.WriteLine(table.Rows[0]["firstname"]);
            //Console.WriteLine(table.Rows[0]["middlename"]);
            //Console.WriteLine(table.Rows[0]["lastname"]);

            //hooks.driver.FindElement(By.Name("firstName")).SendKeys(table.Rows[0]["firstname"]);
            //hooks.driver.FindElement(By.Name("middleName")).SendKeys(table.Rows[0]["middlename"]);
            //hooks.driver.FindElement(By.Name("lastName")).SendKeys(table.Rows[0]["lastname"]);

            addEmployeePage.EnterFirstName(table.Rows[0]["firstname"]);
            addEmployeePage.EnterMiddleName(table.Rows[0]["middlename"]);
            addEmployeePage.EnterLastName(table.Rows[0]["lastname"]);

        }

        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
            //hooks.driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
            addEmployeePage.ClickOnSave();
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
