using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace HerokuWebApplication
{
    public class HomePage : IHomePageOperations
    {
        IWebDriver driver;
        private By titleLocator;
        public HomePage() {
            titleLocator = By.TagName("h1");
            driver = new RemoteWebDriver(new Uri("http://localhost:8090"), new ChromeOptions());
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }
        public string[] getAvailableExamples()
        {
            throw new NotImplementedException();
        }

        public string getGithubLink()
        {
            throw new NotImplementedException();
        }

        public string getSubTitle()
        {
            throw new NotImplementedException();
        }

        public string getTitle()
        {
            return driver.FindElement(titleLocator).Text;
        }

        public void navigateTo(string exampleName)
        {
            throw new NotImplementedException();
        }
    }
}
