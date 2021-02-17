using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Desafio_toro.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement CampoEmail { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement CampoSenha { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".modal-panel-footer--fixed button")]
        public IWebElement BotaoEntrar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#input-field--user .input-error-message")]
        public IWebElement AlertaEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#input-field--pass .input-error-message")]
        public IWebElement AlertaSenha { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form .form-error-message")]
        public IWebElement AlertaDadosIncorretos { get; set; }


        public void PreencherCampo(string campo)
        {
            if (campo.Equals("Email"))
            {
                string Email = "wescleymartins02@gmail.com";
                CampoEmail.SendKeys(Email);

            }else if (campo.Equals("Senha"))
            {
                string Senha = "kurosaki";
                CampoSenha.SendKeys(Senha);
            }
            else
            {
                Assert.Fail();
            }
        }

        public void PreencherCrendenciasValidas()
        {
            string Email = "wescleymartins02@gmail.com";
            string Senha = "kurosaki";

            CampoEmail.SendKeys(Email);
            CampoSenha.SendKeys(Senha);
        }

        public void PreencherCrendenciasEmailInvalido()
        {
            string Email = "xxxWescleyxxxMartins02@gmail.com";
            string Senha = "kurosaki";

            CampoEmail.SendKeys(Email);
            CampoSenha.SendKeys(Senha);
        }

        public void PreencherCrendenciasSenhaInvalida()
        {
            string Email = "wescleymartins02@gmail.com";
            string Senha = "kurosaki@1111";

            CampoEmail.SendKeys(Email);
            CampoSenha.SendKeys(Senha);
        }

        public void PreencherCampoInvalido(string campo)
        {
            if (campo.Equals("Email"))
            {
                PreencherCrendenciasEmailInvalido();

            }else if (campo.Equals("Senha"))
            {
                PreencherCrendenciasSenhaInvalida();
            }
            else
            {
                Assert.Fail();
            }
        }

        public void ClicarBotaoEntrar()
        {
            BotaoEntrar.Click();
        }

        public void ValidarMensagemAlerta(string campo, string mensagemEsperada)
        {
            if (campo.Equals("Email"))
            {
                string mensagemAtual = AlertaEmail.Text;
                Assert.AreEqual(mensagemEsperada, mensagemAtual);

            }else if (campo.Equals("Senha"))
            {
                string mensagemAtual = AlertaSenha.Text;
                Assert.AreEqual(mensagemEsperada, mensagemAtual);

            }
        }

        public void ValidarMensagemDadosIncorretos(string mensagemEsperada)
        {
            string mensagemAtual = AlertaDadosIncorretos.Text;
            Assert.AreEqual(mensagemEsperada, mensagemAtual);
        }

    }
}
