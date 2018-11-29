using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TestAutomationEssentials.Selenium;

namespace BuyMeAutomation
{
    internal class UserAccountDetailsPage
    {
        internal Browser _browser;

        public UserAccountDetailsPage(Browser browser)
        {
            _browser = browser;
        }

        public string Name
        {
          get
            {
                //  return _browser.WaitForElement(By.XPath("//input[@placeholder='שם פרטי']"), "User Name box").Text;

                 IWebDriver driver = _browser.GetWebDriver();
                WebDriverWait wait = new WebDriverWait(driver,new TimeSpan(0,0,30));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("ember-text-field")));
                IList<IWebElement> requiredFields= driver.FindElements(By.ClassName("ember-text-field"));
                 return requiredFields[5].Text;
            }

            set=> throw new NotImplementedException();
        }
        public string Email
        {
            get
            {
                IWebDriver driver = _browser.GetWebDriver();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("ember-text-field")));
                IList<IWebElement> requiredFields = driver.FindElements(By.ClassName("ember-text-field"));
                return requiredFields[2].Text;
            }

            set => throw new NotImplementedException();
        }

    }
    }