using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestAutomationEssentials.MSTest;
using TestAutomationEssentials.Selenium;

namespace BuyMeAutomation
{
    [TestClass]
    public class BuyMeRegistrationTests:TestBase
    {
        LandingPage landingPage;

        protected override void TestInitialize()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Browser browser = new Browser("MVCForum", driver, TestExecutionScopesManager);
            AddCleanupAction(() => browser.Dispose());
            landingPage = new LandingPage(browser);
        }


        [TestMethod]
        public void UserCanRegisterToBuyMe()
        {
            var loginPopUp = landingPage.ClickOnRegisterOrLoginButton();
            var registerPopUp = loginPopUp.ClickOnRegisterButton();

            string name = "dummyUser";
            Random random = new Random();
            string email = name + random.Next(1, 1000).ToString() + "@dummy.com";
            string password = "Aa" + random.Next(1, 10000000);

            registerPopUp.Name = name;
            registerPopUp.Email = email;
            registerPopUp.Password = password;
            registerPopUp.CheckAgreeToPolicy();

            var homePage = registerPopUp.ClickOnRegisterBuyMe();
            homePage.HoverMouseOnMyAccountButton();
            var userAccountDetailsPage = homePage.ClickOnMyAccountDetails();
            Assert.AreEqual(name, userAccountDetailsPage.Name);
            Assert.AreEqual(email, userAccountDetailsPage.Email);
        }
    }
}
