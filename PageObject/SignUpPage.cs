using System;
using System.Collections.Generic;
using System.Text;
using AutomationProject01.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationProject01.PageObject
{
    class SignUpPage
    {

        public SignUpPage()
        {
            driver = Hooks1.driver;
           

        }
        IWebDriver driver;

        String signupPath = "//a[@id='signin2']";
        String usernamesignuppath = "//input[@id='sign-username']";
        String passwordsignuppath = "//input[@id='sign-password']";

        String loginpath = "//a[@id='login2']";
        String usernamepath = "//input[@id='loginusername']";
        String passwordpath = "//input[@id='loginpassword']";
        String loginbutton2path = "//button[contains(text(),'Log in')]";
        String closebuttonpath = "//body/div[@id='logInModal']/div[1]/div[1]/div[3]/button[1]";


        // IWebElement Loginbutton1 => driver.FindElement(By.Id("login2"));
        IWebElement SignUpButton1 => driver.FindElement(By.XPath("//a[@id='signin2']"));
        //LoginButton1 xpath = "//*[@id="login2"]"
        // System.Threading.Thread.Sleep(1000); // does not exist in the current context
        //could have something to do with the utilities


        //you need separate class for each action thats why the context does not exist
        //Loginbutton1.Click(); //why  does it not exist in the current context

      
        IWebElement username => driver.FindElement(By.XPath("//input[@id='sign-username']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@id='sign-password']"));
        IWebElement Loginbutton2 => driver.FindElement(By.XPath("//button[contains(text(),'Sign up')]"));

        public void clickButton1()
        {
            SignUpButton1.Click();
            System.Threading.Thread.Sleep(5000);


        }

        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            //don't do the random int yet
            username.SendKeys("Testusername" + randomInt);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Test user: " + "Testusername" + randomInt);


        }
        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            username.SendKeys("Testusername" + randomInt + "@yahoo.com" );
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Testusername" + randomInt + "@yahoo.com");


        }
        public void EnterPassword()
        {
           
            password.SendKeys("testpassword");
            System.Threading.Thread.Sleep(1000);


        }

        public void clickButton2()
        {
            Loginbutton2.Click();
            System.Threading.Thread.Sleep(1000);


        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            System.Threading.Thread.Sleep(5000);


        }



    }

}

