using PrimeControl.TestesFuncionais.Configs;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace PrimeControl.TestesFuncionais.LeanPrime.PageObjects
{
    public class LeanFormPage
    {
        private IWebDriver driver;

        public LeanFormPage(IWebDriver webdriver)
        {
            driver = webdriver;
        }

        public IWebElement CampoNome()
        {
            var cmpNome = driver.FindElement(By.Id("mauticform_input_whitepaperabordagemleanparaautomacaodetestes_primeiro_nome"));
            return cmpNome;
        }

        public IWebElement CampoSobrenome()
        {
            var cmpSobrenome = driver.FindElement(By.Id("mauticform_input_whitepaperabordagemleanparaautomacaodetestes_sobrenome"));
            return cmpSobrenome;
        }

        public IWebElement ComboCargo()
        {
            var comboCargo = driver.FindElement(By.Id("mauticform_input_whitepaperabordagemleanparaautomacaodetestes_cargo"));
            return comboCargo;
        }

        public IWebElement ComboUf()
        {
            var comboUf = driver.FindElement(By.Id("mauticform_input_whitepaperabordagemleanparaautomacaodetestes_estado1"));
            return comboUf;
        }

        public IWebElement CampoEmpresa()
        {
            var campoEmpresa = driver.FindElement(By.Id("mauticform_input_whitepaperabordagemleanparaautomacaodetestes_nome_da_empresa"));
            return campoEmpresa;
        }

        public IWebElement CampoEmail()
        {
            var campoEmail = driver.FindElement(By.Id("mauticform_input_whitepaperabordagemleanparaautomacaodetestes_email"));
            return campoEmail;
        }

        public IWebElement BotaoEnviar()
        {
            var btnEnviar = driver.FindElement(By.Id("mauticform_input_whitepaperabordagemleanparaautomacaodetestes_fazer_download"));
            btnEnviar.Click();
            return btnEnviar;
        }

        public IWebElement MsgSucesso()
        {
            var msgSucesso = driver.FindElement(By.Id("mauticform_whitepaperabordagemleanparaautomacaodetestes_message"));
            return msgSucesso;
        }

        public IWebElement MsgErro()
        {
            var msgErro = driver.FindElement(By.ClassName("mauticform-errormsg"));
            return msgErro;
        }

        public void NavegarLean()
        {
            driver.Navigate().GoToUrl(ConfigurationBinding.BaseURL + "automacao-de-testes-com-abordagem-lean");
            driver.Manage().Window.Maximize();
        }

        public void FormularioLean(string nome, string sobrenome, string cargo, string uf, string empresa, string email)
        {
            CampoNome().Clear();
            CampoNome().SendKeys(nome);
            CampoSobrenome().Clear();
            CampoSobrenome().SendKeys(sobrenome);
            ComboCargo().SendKeys(cargo);
            ComboUf().SendKeys(uf);
            CampoEmpresa().Clear();
            CampoEmpresa().SendKeys(empresa);
            CampoEmail().Clear();
            CampoEmail().SendKeys(email);
            BotaoEnviar();
        }

    }
}
