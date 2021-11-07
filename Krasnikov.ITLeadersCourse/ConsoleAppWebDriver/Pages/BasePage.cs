using ConsoleApp.WebDriver.Drivers;
using OpenQA.Selenium;

namespace ConsoleApp.WebDriver
{
    public class BasePage
    {
        protected IWebDriver Driver { get; }

        public BasePage()
        {
            this.Driver = WebDriverManager.Driver;
        }

        protected void NavigateBack()
        {
            Driver.Navigate().Back();
        }

        protected IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        protected IList<IWebElement> FindElements(By locator)
        {
            return Driver.FindElements(locator);
        }
    }
}
