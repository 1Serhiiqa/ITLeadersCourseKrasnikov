using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson6_AdditionalWindows
{
    public class AdditionalWindowPage : BasePage
    {
        //1. Declare class AdditionalWindowsPage
        //2. Declare all necessary locators to handle with buttons

        private IWebElement NewBrowserWindowLink => FindElement(By.Id("button1"));

        public AutomationPracticePage ClickNewBrowserWindowLink()
        {
            NewBrowserWindowLink.Click();

            return new AutomationPracticePage();
        }










    }
}
