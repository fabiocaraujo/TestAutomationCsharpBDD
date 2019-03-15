using System;
using OpenQA.Selenium;
using PrimeControl.TestesFuncionais.Configs;

namespace PrimeControl.TestesFuncionais.HomePrime.PageObjects
{
    public class HomePrimePage
    {
        private IWebDriver driver;

        public HomePrimePage(IWebDriver webdriver)
        {
            driver = webdriver;
        }

        public IWebElement Logo()
        {
            var logo = driver.FindElement(By.ClassName("g1-logo"));
            return logo;
        }

        public IWebElement MenuQuemsomos()
        {
            var menu = driver.FindElement(By.Name("Quem Somos")); // ClassName("menu -item-20 .g1-nav-item__title"));
            return menu;
        }

        public IWebElement BtnSaibaMais()
        {
            var btnSaibaMais = driver.FindElement(By.ClassName("vc_btn3-container vc_btn3-center"));
            return btnSaibaMais;
        }

        public void NavegarHome()
        {
            driver.Navigate().GoToUrl(ConfigurationBinding.BaseURL);
            driver.Manage().Window.Maximize();
        }

        public IWebElement Titulo()
        {
            var txtTitulo = driver.FindElement(By.ClassName("entry-title"));
            txtTitulo.GetAttribute("value");
            return txtTitulo;
        }
    }
}


