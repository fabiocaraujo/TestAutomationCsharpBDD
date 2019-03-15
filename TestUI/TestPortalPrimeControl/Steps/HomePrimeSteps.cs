using System;
using TechTalk.SpecFlow;
using PrimeControl.TestesFuncionais.HomePrime.PageObjects;
using OpenQA.Selenium;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Compatibility;


namespace PrimeControl.TestesFuncionais.HomePrime.Steps
{
    [Binding]
    public class HomePrimeSteps
    {
        private IWebDriver driver;
        private HomePrimePage home;


        public HomePrimeSteps(IWebDriver _driver)
        {
            this.driver = _driver;
            home = new HomePrimePage(this.driver);
        }

        [Given("que navegue para a home")]
        public void Givenquenavegueparaahome()
        {
            home.NavegarHome();
    
        }

        [Then("deve validar elementos da tela inicial")]
        public void Thendevevalidarelementosdatelainicial()
        {
            Assert.AreEqual(home.Titulo(), "Automação de Testes");

        }
    }
}
