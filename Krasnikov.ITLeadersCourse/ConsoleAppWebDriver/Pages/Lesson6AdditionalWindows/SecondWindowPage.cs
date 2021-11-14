using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows
{
    public class SecondWindowPage : BasePage
    {
        private IWebElement ThirdPageLink => FindElement(By.Id("thirdWindowLink"));

        public ThirdWindowPage ClickThirdPageLink()
        {
            ThirdPageLink.Click();

            return new ThirdWindowPage();
        }

    }
}
