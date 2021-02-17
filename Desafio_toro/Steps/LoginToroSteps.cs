using Desafio_toro.Common;
using System;
using TechTalk.SpecFlow;

namespace Desafio_toro.Steps
{
    [Binding]
    public class LoginToroSteps : BaseTests
    {
        [Given(@"que o usuário acesse a aplicação")]
        public void DadoQueOUsuarioAcesseAAplicacao()
        {
            toroPage.AcessarAplicacao(driver);
        }
        
        [Given(@"entre na página de login")]
        public void DadoEntreNaPaginaDeLogin()
        {
            toroPage.AcessarAreaLogin(driver);
        }
        
        [When(@"o usuário informar credencias válidas")]
        public void QuandoOUsuarioInformarCredenciasValidas()
        {
            loginPage.PreencherCrendenciasValidas();
        }
        
        [When(@"clicar no botão Entrar")]
        public void QuandoClicarNoBotaoEntrar()
        {
            loginPage.ClicarBotaoEntrar();
        }
        
        [Then(@"a aplicação deverá exibir a página inicial com nome do usuário logado")]
        public void EntaoAAplicacaoDeveraExibirAPaginaInicialComNomeDoUsuarioLogado()
        {
            homePage.ValidarUsuarioLogado();
        }

        [When(@"o usuário clicar no botão Entrar")]
        public void QuandoOUsuarioClicarNoBotaoEntrar()
        {
            loginPage.ClicarBotaoEntrar();
        }

        [Then(@"a aplicação deverá exibir a mensagem '(.*)' no campo '(.*)'")]
        public void EntaoAAplicacaoDeveraExibirAMensagemNoCampo(string mensagem, string campo)
        {
            loginPage.ValidarMensagemAlerta(campo, mensagem);
        }


        [Then(@"a mensagem ""(.*)"" no campo ""(.*)""")]
        public void EntaoAMensagemNoCampo(string mensagem, string campo)
        {
            loginPage.ValidarMensagemAlerta(campo, mensagem);
        }

        [Then(@"a aplicação deverá exibir a mensagem ""(.*)""")]
        public void EntaoAAplicacaoDeveraExibirAMensagem(string mensagemEsperada)
        {
            loginPage.ValidarMensagemDadosIncorretos(mensagemEsperada);
        }

        [When(@"preencher o campo '(.*)' com um valor inválido")]
        public void QuandoPreencherOCampoComUmValorInvalido(string campo)
        {
            loginPage.PreencherCampoInvalido(campo);
        }

        [When(@"preencher o campo '(.*)'")]
        public void QuandoPreencherOCampo(string campo)
        {
            loginPage.PreencherCampo(campo);
        }

    }
}
