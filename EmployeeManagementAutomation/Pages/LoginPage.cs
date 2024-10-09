using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class LoginPage
    {
        private By usernameLocator = By.Name("username");
        private By passwordLocator = By.Name("password");
        private By loginLocator = By.XPath("//button[contains(normalize-space(),'Login')]");
        private By errorLocator = By.XPath("//p[contains(normalize-space(),'Invalid')]");

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            driver.FindElement(loginLocator).Click();
        }

        public string GetInvalidErrorMessage()
        {
            return driver.FindElement(errorLocator).Text;
        }
    }
}
