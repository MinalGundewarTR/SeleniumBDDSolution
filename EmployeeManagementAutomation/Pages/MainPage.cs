using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class MainPage
    {
        private By PIMLocator = By.XPath("//span[text()='PIM']");

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnPIMMenu()
        {
            driver.FindElement(PIMLocator).Click();
        }
    }
}
