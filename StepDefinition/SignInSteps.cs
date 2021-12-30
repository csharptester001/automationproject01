using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using AutomationProject01.PageObject;

namespace AutomationProject01.StepDefinition
{
    [Binding]
    public class SignInSteps
    {

        SignInPage signInPage;

        public SignInSteps()
        {
            signInPage = new SignInPage();
        }



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            //ScenarioContext.Current.Pending();
            signInPage.NavigateToWebsite();

        }
        [Given(@"I click login button")]
        public void IclickSignUp()
        {
            signInPage.clickButton1();

        }


        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            signInPage.EnterUsername();
        }


        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            signInPage.EnterPassword();
        }



        [Given(@"I click Login")]
        public void IclickLogin()
        {
            signInPage.clickButton2();
        }
/*
        [When(@"I should be able to login")]
        public void WhenICickOnSignUp()
        {
            signInPage.clickButton2();
        }
*/
        [Then(@"I should be able to login")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
