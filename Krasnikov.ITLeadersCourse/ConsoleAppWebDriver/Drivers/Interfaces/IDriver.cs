using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Drivers.Interfaces
{
    public interface IDriver
    {
        IWebDriver Setup(string pathToDriver);
    }
}
