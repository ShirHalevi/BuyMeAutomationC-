using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using TestAutomationEssentials.Selenium;

namespace BuyMeAutomation
{
    internal class HomePage
    {
        private readonly Browser _browser;

        public HomePage(Browser browser)
        {
            _browser = browser;
        }

        internal void HoverMouseOnMyAccountButton()
        {
                _browser.WaitForElement(By.ClassName("arrow"), "My account menu bar button").Hover();
        }

        internal UserAccountDetailsPage ClickOnMyAccountDetails()
        {
            _browser.WaitForElement(By.XPath("//a[@href='https://buyme.co.il/myAccount?tab=details']"),"Account details button").Click();
            return new UserAccountDetailsPage(_browser);
        }
    }
}