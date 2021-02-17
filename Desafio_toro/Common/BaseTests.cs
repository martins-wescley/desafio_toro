using Desafio_toro.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Desafio_toro.Common
{
    public class BaseTests
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public ToroPage toroPage;
        public HomePage homePage;

        [BeforeScenario]
        public void IniciarTeste()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IniciarElementos(driver);
        }

        public void IniciarElementos(IWebDriver driver)
        {
            toroPage = new ToroPage();
            loginPage = new LoginPage();
            homePage = new HomePage();
            
            PageFactory.InitElements(driver, toroPage);
            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, homePage);
        }

        [AfterScenario]
        public void FinalizarTeste()
        {
            driver.Quit();
            driver = null;
        }
    }
}
