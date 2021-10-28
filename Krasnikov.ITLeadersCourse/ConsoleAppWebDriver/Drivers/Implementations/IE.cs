using ConsoleApp.WebDriver.Drivers.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace ConsoleApp.WebDriver.Drivers.Implementations
{
    public class IE : IDriver
    {
        public IWebDriver Setup(string pathToDriver)
        {
            IWebDriver driver = new InternetExplorerDriver(pathToDriver);

            driver.Manage().Window.Maximize();

            return driver;
        }


    }
}