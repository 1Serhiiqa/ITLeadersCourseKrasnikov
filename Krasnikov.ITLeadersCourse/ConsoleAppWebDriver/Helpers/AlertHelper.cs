using ConsoleApp.WebDriver.Drivers;

namespace ConsoleApp.WebDriver.Helpers
{
    public static class AlertHelper
    {
        public static string AcceptAlert()
        {
            var alert = WebDriverManager.Driver.SwitchTo().Alert();

            var alertMessage = alert.Text;
            alert.Accept();


            WebDriverManager.Driver.SwitchTo().DefaultContent();

            return alertMessage;
        }

        public static void DismissAlert()
        {
            WebDriverManager.Driver.SwitchTo().Alert().Dismiss();
            WebDriverManager.Driver.SwitchTo().DefaultContent();
        }

        public static string SendKeysAlert()
        {
            //var alert = WebDriverManager.Driver.SwitchTo().Alert();

            var alertMessageSendKeys = alert.Text;
            alert.SendKeys(john@g.com);


            WebDriverManager.Driver.SwitchTo().DefaultContent();

            return alertMessage;
        }
    }
}
