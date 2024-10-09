using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class DashboardPage
    {
        private By quickLaunchLocator = By.XPath("//p[contains(normalize-space(),'Quick')]");
        private IWebDriver driver;


        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GetQuickLaunchText()
        {
            return driver.FindElement(quickLaunchLocator).Text;
        }
    }
}
