using ConsoleApp.WebDriver.Pages;
using ConsoleApp.WebDriver.Pages.Lesson7IFrame;
using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson7_IFrame
{

    public class MyFramePage : BasePage
    {







        //1. Go to Frame 2
        private IWebElement SecondFrameElement => FindElement(By.Id("frame2"));

        //private IWebElement MyFramePageHeader => FindElement(By.Id("pageHeader"));

        private IWebElement InputUserName => FindElement(By.Id("userName"));

        private IWebElement CheckUserNameButton => FindElement(By.Id("checkUserName"));

        private IWebElement ResultMessage => FindElement(By.Id("output"));

        public SecondFramePage SwitchToSecondFrame()
        {
            Driver.SwitchTo().Frame(SecondFrameElement);

            return new SecondFramePage();
        }

        public MyFramePage SwitchToSelf()
        {
            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public MyFramePage InputUserNameField()
        {
            Driver.ToString(FullUserName);

            return this;
        }
        public MyFramePage ClickCheckUserNameButton()
        {
            CheckUserNameButton.Click();

            return this;
        }

        public string GetResultMessage()
        {
            return ResultMessage.Text;
        }


    }
}