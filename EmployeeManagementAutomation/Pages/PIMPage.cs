using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class PIMPage
    {
        private IWebDriver driver;
        private By AddMenuLocator = By.XPath("//button[normalize-space()='Add']");

        public PIMPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickOnAddEmployeeMenu()
        {
            driver.FindElement(AddMenuLocator).Click();
        }

    }
}
