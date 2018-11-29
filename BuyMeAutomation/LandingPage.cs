using OpenQA.Selenium;
using System;
using TestAutomationEssentials.Selenium;

namespace BuyMeAutomation
{
    internal class LandingPage
    {
        private Browser _browser;

        public LandingPage(Browser browser)
        {
            _browser = browser;
            _browser.NavigateToUrl("https://buyme.co.il");
        }

        public LoginPopUp ClickOnRegisterOrLoginButton()
        {
            _browser.WaitForElement(By.ClassName("seperator-link"), "Register and login button").Click();
            return new LoginPopUp(_browser);
        }
    }
}