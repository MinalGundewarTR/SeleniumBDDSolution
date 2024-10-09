using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class AddEmployeePage
    {
        private IWebDriver driver;
        private By firstNameLocator = By.Name("firstName");
        private By middleNameLocator = By.Name("middleName");
        private By lastNameLocator = By.Name("lastName");
        private By saveButtonLocator = By.XPath("//button[normalize-space()='Save']");

        public AddEmployeePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterFirstName(string firstName)
        {
            driver.FindElement(firstNameLocator).SendKeys(firstName);
        }

        public void EnterMiddleName(string middleName)
        {
            driver.FindElement(middleNameLocator).SendKeys(middleName);
        }

        public void EnterLastName(string lastName)
        {
            driver.FindElement(lastNameLocator).SendKeys(lastName);
        }

        public void ClickOnSave()
        {
            driver.FindElement(saveButtonLocator).Click();
        }
    }
}
