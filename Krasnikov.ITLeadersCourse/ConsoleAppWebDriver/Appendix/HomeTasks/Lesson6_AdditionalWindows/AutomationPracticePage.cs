using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson6_AdditionalWindows
{
    public class AutomationPracticePage : BasePage
    {

        private IWebElement NewMessageWindowLink => FindElement(By.XPath("//button[@onclick='newMsgWin']"));

        public MessageWindowPage ClickNewMessageWindowLink()
        {
            NewMessageWindowLink.Click();

            return new MessageWindowPage();
        }

    }
}
