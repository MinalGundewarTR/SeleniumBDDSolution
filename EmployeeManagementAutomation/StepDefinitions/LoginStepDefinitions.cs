using EmployeeManagementAutomation.Hooks;
using EmployeeManagementAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private LoginPage login;
        private DashboardPage dashboard;
        private AutomationHooks hooks;
        
        //public IWebDriver driver = new ChromeDriver();
        public LoginStepDefinitions(AutomationHooks hooks) 
        {
            //local variable = parameter
            this.hooks = hooks;
        }

        [Given(@"I have browser with OrangeHRM application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            hooks.driver = new ChromeDriver();
            hooks.driver.Manage().Window.Maximize();
            hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            hooks.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

            InitPageObject();
            //For static methods of AutomationHooks class.
            //AutomationHooks.driver = new ChromeDriver();
            //AutomationHooks.driver.Manage().Window.Maximize();
            //AutomationHooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            //AutomationHooks.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        public void InitPageObject()
        {
            login = new LoginPage(hooks.driver);
            dashboard = new DashboardPage(hooks.driver);

        }

        [When(@"I enter username as '(.*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            login.EnterUsername(username);
            //hooks.driver.FindElement(By.Name("username")).SendKeys(username);  
        }

        [When(@"I enter password as '(.*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            login.EnterPassword(password);
            //hooks.driver.FindElement(By.Name("password")).SendKeys(password);
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            login.ClickOnLogin();
            //hooks.driver.FindElement(By.XPath("//button[normalize-space() = 'Login']")).Click();
        }

        [Then(@"I should get access to dashboard page with '(.*)'")]
        public void ThenIShouldGetAccessToDashboardPageWith(string expectedText)
        {
            //string actualText = hooks.driver.FindElement(By.XPath("//p[contains(normalize-space(),'Quick')]")).Text;
            Assert.That(dashboard.GetQuickLaunchText(), Is.EqualTo(expectedText));


        }
        [Then(@"I should not get access to dashboard with error as '(.*)'")]
        public void ThenIShouldNotGetAccessToDashboardWithErrorAs(string expectedError)
        {
            //string actualError = hooks.driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid')]")).Text;
            Assert.That(login.GetInvalidErrorMessage(), Is.EqualTo(expectedError));

        }


    }
}