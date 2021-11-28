using NUnitFramework.Enums;

namespace NUnitFramework.Drivers.Interfaces
{
    public abstract class IDriverFactory
    {
        public abstract IDriver GetDriver(BrowserType driverType);
    }
}
