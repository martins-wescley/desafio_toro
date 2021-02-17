using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using System;
using System.Configuration;

namespace Desafio_toro.Pages
{
    public class ToroPage
    {
        public void AcessarAplicacao(IWebDriver driver)
        {
            string Url = "https://www.toroinvestimentos.com.br/";
            Console.WriteLine(Url);
            driver.Navigate().GoToUrl(Url);
        }

        public void AcessarAreaLogin(IWebDriver driver)
        {
            driver.FindElement(By.LinkText("ENTRAR")).Click();
        }
    }
}
