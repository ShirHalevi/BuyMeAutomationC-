using OpenQA.Selenium;
using System;
using TestAutomationEssentials.Selenium;

namespace BuyMeAutomation
{
    internal class RegisterPopUp
    {
        private readonly Browser _browser;

        public RegisterPopUp(Browser browser)
        {
            _browser = browser;
        }

        public string Name
        {
            get => throw new NotImplementedException(); 

             set
            {
                var nameTextBox= _browser.WaitForElement(By.Id("ember974"), "First Name Field");
                nameTextBox.Text = value;

            }
        }

        public string Email
        {
            get => throw new NotImplementedException();
             set
            {
                var emailTextBox=_browser.WaitForElement(By.Id("ember976"), "Email field");
                 emailTextBox.Text = value;
            }
        }

        public string Password
        {
            get => throw new NotImplementedException();
             set
            {
              var password= _browser.WaitForElement(By.Id("valPass"), "password field");
                password.Text = value;

                password=_browser.WaitForElement(By.Id("ember980"), "Ensure Password field");
                password.Text = value;
            }
        }

        internal void CheckAgreeToPolicy()
        {
            _browser.WaitForElement(By.Id("ember981-name"), "I agree to conditions check box").Click(); ;
        }

        internal HomePage ClickOnRegisterBuyMe()
        {
            _browser.WaitForElement(By.XPath("//button[@type='submit']"),"Register to by me submit button").Click();
            return new HomePage(_browser);
        }

    }
}