using ConsoleApp.WebDriver.Drivers.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp.WebDriver.Drivers.Implementations
{
    public class Chrome : IDriver
    {
        public IWebDriver Setup(string pathToDriver)
        {
            IWebDriver driver = new ChromeDriver(pathToDriver);

            driver.Manage().Window.Maximize();

            return driver;
        }

    }
}
