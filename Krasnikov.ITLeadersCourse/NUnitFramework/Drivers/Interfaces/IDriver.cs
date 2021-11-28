using OpenQA.Selenium;


namespace NUnitFramework.Drivers.Interfaces
{
    public interface IDriver
    {
        IWebDriver Setup(string pathToDriver);
    }
}
