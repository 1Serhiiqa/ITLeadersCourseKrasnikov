using ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson7_IFrame;
using OpenQA.Selenium;


namespace ConsoleApp.WebDriver.Pages.Lesson7IFrame
{
    public class SecondFramePage : BasePage
    {

        private IWebElement ThirdFrameElement => FindElement(By.Id("innerFrame"));

        //private IWebElement SecondFrameHeader => FindElement(By.XPath("//[text()='Frame 2']"));

        private IWebElement LastNameTextField => FindElement(By.Id("lastName"));

        private IWebElement MyFramePageElement => FindElement(By.Id("frame2"));

        public string GetLastNameTextField() => LastNameTextField.Text;

        public ThirdFramePage SwitchToThirdFrame()
        {
            Driver.SwitchTo().Frame(ThirdFrameElement);

            return new ThirdFramePage();
        }

        public SecondFramePage SwitchToSelf()
        {
            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public MyFramePage SwitchToMyFramePage()
        {
            Driver.SwitchTo().Frame(MyFramePageElement);

            return new MyFramePage();
        }
    }
}
