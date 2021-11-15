using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson6_AdditionalWindows
{
    public class MessageWindowPage : BasePage
    {

        private IWebElement NewMessageWindowText => FindElement(By.XPath("//p['Knowledge increases by sharing but not by saving.Please share this website with your friends and in your organization.']"));

        public string GetNewMessageWindowText()
        {
            return NewMessageWindowText.Text;

        }
    }
}
