using ConsoleApp.WebDriver.Enums;

namespace ConsoleApp.WebDriver.Drivers.Interfaces
{
    public abstract class IDriverFactory
    {
        public abstract IDriver GetDriver(BrowserType driverType);
    }
}
