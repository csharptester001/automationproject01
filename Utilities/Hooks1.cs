using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject01.Utilities
{
    [Binding]

    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           // driver.Navigate().GoToUrl("https://www.demoblaze.com/");    
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            //Quit the browser after running the beforescenario
            
            driver.Quit();
            
        }
    }
}
