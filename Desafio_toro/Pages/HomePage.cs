using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_toro.Pages
{
    public class HomePage
    {
        [FindsBy(How = How.CssSelector, Using = ".header-title h5")]
        public IWebElement UsuarioLogado { get; set; }

        public void ValidarUsuarioLogado()
        {
            string usuarioLogado = UsuarioLogado.Text;
            StringAssert.Contains("Wescley", usuarioLogado);
        }
    }
}
