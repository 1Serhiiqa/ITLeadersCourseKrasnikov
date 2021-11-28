using NUnitFramework.Enums;

namespace NUnitFramework.Logging.Interfaces
{
    public abstract class ILoggerFactory
    {
        public abstract ILoggerInstance GetLogger(LoggerType Logger);
    }
}
