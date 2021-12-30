using System;
using TechTalk.SpecFlow;
using AutomationProject01.PageObject;


namespace AutomationProject01.StepDefinition
{
    [Binding]
    public class SignUpSteps
    {

        SignUpPage signUpPage;

        public SignUpSteps()
        {
            signUpPage = new SignUpPage();
        }



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            //ScenarioContext.Current.Pending();
            signUpPage.NavigateToWebsite();

        }


        [Given(@"I click Sign Up")]
        public void IclickSignUp()
        {
            signUpPage.clickButton1();

        }

        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            signUpPage.EnterUsername();
        }

   

        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            signUpPage.EnterPassword();
        }

        [When(@"I cick on Sign up")]
        public void WhenICickOnSignUp()
        {
            signUpPage.clickButton2();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
