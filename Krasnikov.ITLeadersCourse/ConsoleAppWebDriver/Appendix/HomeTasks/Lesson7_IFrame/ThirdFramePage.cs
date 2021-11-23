using ConsoleApp.WebDriver.Pages;
using ConsoleApp.WebDriver.Pages.Lesson7IFrame;
using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson7_IFrame
{
    public class ThirdFramePage : BasePage
    {

        private IWebElement NameTextField => FindElement(By.Id("name"));

        // must edit XPath - private IWebElement ThirdFrameHeader => FindElement(By.XPath("//id#innerFrame[text()='Frame 1']"));

        private IWebElement SecondFrameElement => FindElement(By.Id("frame2"));

        public string GetNameTextField() => NameTextField.Text.Split(": ")[1];

        public SecondFramePage SwitchToSecondFrame()
        {
            Driver.SwitchTo().Frame(SecondFrameElement);

            return new SecondFramePage();
        }

    }
}
