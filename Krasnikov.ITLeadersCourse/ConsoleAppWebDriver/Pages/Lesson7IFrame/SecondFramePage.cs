using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Pages.Lesson7IFrame
{
    public class SecondFramePage : BasePage
    {

        private IWebElement LastNameTextField => FindElement(By.Id("lastName"));

        public string GetLastNameTextField() => LastNameTextField.Text;
    }
}
