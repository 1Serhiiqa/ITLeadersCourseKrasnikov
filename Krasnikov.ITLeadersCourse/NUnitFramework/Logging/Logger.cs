using NUnitFramework.Logging.Implementations;
using NUnitFramework.Logging.Interfaces;
using static NUnitFramework.AppSettings.SettingsConfigurator;

namespace NUnitFramework.Logging
{
    public class Logger
    {
        private static ILoggerInstance loggerInstance;

        public static ILoggerInstance Log
        {
            get
            {
                return loggerInstance ??= new LoggerFactory()
                        .GetLogger(Settings.Logger)
                        .SetUp();
            }
        }
    }
}
