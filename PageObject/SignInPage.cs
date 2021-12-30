using AutomationProject01.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject01.PageObject
{

    class SignInPage
    {

        public SignInPage()
        {
            driver = Hooks1.driver;


        }

        //todo we need to create an automated script to login using a known username and a known password
        //then update the step definition for sign in

        //this test should fail because username is random and you cant login with it

    
        OpenQA.Selenium.IWebDriver driver;

        String signInPath = "//a[@id='signin2']";
        String usernameSigninPath = "//input[@id='loginusername']";
        String passwordSigninPath = "//body/div[@id='logInModal']/div[1]/div[1]/div[2]/form[1]/div[2]";
        String loginButtonPath = "//button[contains(text(),'Log in')]";
        String closeButtonPath = "//body/div[@id='logInModal']/div[1]/div[1]/div[3]/button[1]";

        IWebElement SignUpButton1 => driver.FindElement(By.XPath(signInPath));
        IWebElement username => driver.FindElement(By.XPath(usernameSigninPath));
        IWebElement password => driver.FindElement(By.XPath(passwordSigninPath));
        IWebElement Loginbutton2 => driver.FindElement(By.XPath(loginButtonPath));

        String testUserName = "testuser12345";
        String testPassword = "testpassword12345";

        public void clickButton1()
        {
            SignUpButton1.Click();
            System.Threading.Thread.Sleep(3000);


        }

        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //don't do the random int yet
            username.SendKeys(testUserName);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(testUserName);


        }

        //we dont need email for this sign up page
        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            username.SendKeys("Testusername" + randomInt + "@yahoo.com");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Testusername" + randomInt + "@yahoo.com");


        }
        public void EnterPassword()
        {

            password.SendKeys(testPassword);
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
