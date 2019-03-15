using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PrimeControl.TestesFuncionais.Configs
{
    [Binding]
    public class ConfigurationBinding
    {
        public static string BaseURL = "https://www.primecontrol.com.br/";

        private readonly IObjectContainer objectContainer;
                
        public ConfigurationBinding(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }
        

        
        [BeforeScenario("web")]
        public void InitializeWebDriver()
        {
            var driver = WebDriverFactory.Create();
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario("web")]
        public void DisposeWebDriver()
        {
            var driver = objectContainer.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
