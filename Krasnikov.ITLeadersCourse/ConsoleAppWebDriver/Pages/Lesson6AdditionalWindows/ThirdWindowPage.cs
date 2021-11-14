using OpenQA.Selenium;
using System;

namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    public class ThirdWindowPage : BasePage
    {
        private IWebElement MessageText => FindElement(Byte.Id("message"));

        public string GetMessage()
        {
            return MessageText.Text;
        }

    }
}
