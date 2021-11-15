using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    public class ThirdWindowPage : BasePage
    {
        private IWebElement MessageText => FindElement(By.Id("message"));

        public string GetMessage()
        {
            return MessageText.Text;
        }

    }
}
