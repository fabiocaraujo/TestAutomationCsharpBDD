using System;
using PrimeControl.TestesFuncionais.LeanPrime.PageObjects;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;

namespace PrimeControl.TestesFuncionais.LeanPrime.Steps
{
    [Binding]
    public class LeanPrimeSteps
    {
        private IWebDriver driver;
        private LeanFormPage lean;


        public LeanPrimeSteps(IWebDriver _driver)
        {
            this.driver = _driver;
            lean = new LeanFormPage(this.driver);
        }

        [Given("que eu navegue até a pagina do formulário Lean")]
        public void GivenqueeunavegueateapaginadoformularioLean()
        {
            lean.NavegarLean();
        }

        [When("eu preencher os campos \"Nome\", \"Sobrenome\", \"Cargo\",\"Uf\",\"Empresa\",\"Email\"")]
        public void Wheneupreencheroscampos(string Nome, string Sobrenome, string Cargo, string Uf, string Empresa, string Email)
        {
            lean.FormularioLean(Nome, Sobrenome, Cargo, Uf, Empresa, Email);
        }

        [Then("deve exibir uma mensagem de sucesso")]
        public void Thendeveexibirumamensagem(string mensagem)
        {
            Assert.AreEqual(lean.MsgSucesso(), mensagem);
        }

        [When("eu preencher com dados inválidos os campos \"Nome\", \"Sobrenome\", \"Cargo\",\"Uf\",\"Empresa\",\"Email\"")]
        public void Wheneupreenchercomdadosinválidososcampos(string Nome, string Sobrenome, string Cargo, string Uf, string Empresa, string Email)
        {
            lean.FormularioLean(Nome, Sobrenome, Cargo, Uf, Empresa, Email);
        }

        [Then("deve exibir uma mensagem de erro")]
        public void Thendeveexibirumamensagemdeerro()
        {
            //Assert.IsTrue(lean.MsgErro().Displayed(), "Erro");
        }
    }
}
