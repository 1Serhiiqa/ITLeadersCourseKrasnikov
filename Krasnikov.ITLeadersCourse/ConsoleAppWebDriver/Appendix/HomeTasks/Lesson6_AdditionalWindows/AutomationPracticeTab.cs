using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson6_AdditionalWindows

{
    public class AutomationPracticeTab : BasePage
    {

        private IWebElement NewBrowserTabTitle => FindElement(By.XPath("//head//title"));


        //5. Get New browser window url compare it with expected "https://ultimateqa.com/automation"
        public string GetNewBrowserTabTitle()
        {
            //return NewBrowserTabTitle.Text;
            return Driver.Title;
        }
    }
}
