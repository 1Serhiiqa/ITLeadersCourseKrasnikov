using NUnitFramework.Drivers;
using OpenQA.Selenium;

namespace NUnitFramework.Helpers
{
    public static class AlertHelper
    {

        public static string AcceptAlert(this IAlert alert)
        {
            var alertMessage = alert.Text;
            alert.AcceptAlert();

            WebDriverManager.Driver.SwitchTo().DefaultContent();

            return alertMessage;
        }
    }
}
