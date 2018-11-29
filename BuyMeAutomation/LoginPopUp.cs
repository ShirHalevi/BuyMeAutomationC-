using OpenQA.Selenium;
using System;
using TestAutomationEssentials.Selenium;

namespace BuyMeAutomation
{
    internal class LoginPopUp
    {
        private readonly Browser _browser;

        public LoginPopUp(Browser browser)
        {
            _browser = browser;
        }

        internal RegisterPopUp ClickOnRegisterButton()
        {
            _browser.WaitForElement(By.ClassName("text-btn"), "Registr Button on Entry pop up").Click();
            return new RegisterPopUp(_browser);

        }
    }
} 