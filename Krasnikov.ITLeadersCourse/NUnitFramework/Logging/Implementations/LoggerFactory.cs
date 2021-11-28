using NUnitFramework.Enums;
using NUnitFramework.Logging.Interfaces;
using System;

namespace NUnitFramework.Logging.Implementations
{
    public class LoggerFactory : ILoggerFactory
    {
        public override ILoggerInstance GetLogger(LoggerType logger)
        {
            return logger switch
            {
                LoggerType.Log4Net => new Log4NetInstance(),
                _ => throw new PlatformNotSupportedException($"{logger} type is not supported.")
            };
        }
    }
}
