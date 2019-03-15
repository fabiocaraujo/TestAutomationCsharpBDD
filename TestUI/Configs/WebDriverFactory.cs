using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace PrimeControl.TestesFuncionais.Configs
{
    public enum DriverType
    {
        Chrome, Firefox, IE, PhantomJS
    }

    public static class WebDriverFactory
    {
        public static IWebDriver Create()
        {
            var driver = new ChromeDriver(DriversPath);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            return driver;
        }

        public static string DriversPath
        {
            get
            {
                return Path.Combine(AppContext.BaseDirectory, "Drivers");
            }
        }
    }
}
