using ConsoleApp.WebDriver.Drivers.Implementations;
using ConsoleApp.WebDriver.Drivers.Implementations;
using ConsoleApp.WebDriver.Enums;
using OpenQA.Selenium;
using System;


namespace ConsoleApp.WebDriver.Drivers
{
    public class WebDriverManager
    {
        private static IWebDriver driver;
        private static BrowserType BrowserType => BrowserType.Chrome;
        //private static BrowserType BrowserType => BrowserType.IE;
        private static string PathToDriver => AppDomain.CurrentDomain.BaseDirectory;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new DriverFactory()
                            .GetDriver(BrowserType)
                            .Setup(PathToDriver);
                }
                return driver;
            }
        }

        public static void DisposeDriver()
        {
            driver.Close();
            driver.Dispose();

        }
    }
}
