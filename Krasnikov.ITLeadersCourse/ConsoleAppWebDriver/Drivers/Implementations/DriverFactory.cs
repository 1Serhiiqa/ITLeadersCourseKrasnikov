using ConsoleApp.WebDriver.Drivers.Interfaces;
using ConsoleApp.WebDriver.Enums;
using System;

namespace ConsoleApp.WebDriver.Drivers.Implementations
{
    public class DriverFactory : IDriverFactory
    {
        public override IDriver GetDriver(BrowserType driverType)
        {
            switch (driverType)
            {
                case BrowserType.Chrome:
                    return new Chrome();
                //case BrowserType.IE:
                //return new IE();

                default:
                    throw new PlatformNotSupportedException($"{driverType} browser is not supported!");
            }
        }
    }
}
