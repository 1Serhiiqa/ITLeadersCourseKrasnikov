using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson8_ComplexActions
{
    public class MySelectablePage : BasePage
    {

        private IWebElement DemoFrame => FindElement(By.ClassName("demo-frame"));

        private IWebElement Item1Element => FindElement(By.CssSelector("ol#Item 1"));
        private IWebElement Item3Element => FindElement(By.CssSelector("ol#Item 3"));

        private IWebElement Item5Element => FindElement(By.CssSelector("ol#Item 5"));

        private IWebElement Item7Element => FindElement(By.CssSelector("ol#Item 7"));

        private IWebElement MessageElement => FindElement(By.Id("selectable"));

        public MySelectablePage SwitchToDemoFrame()
        {
            Driver.SwitchTo().Frame(DemoFrame);

            return this;
        }

        public MySelectablePage ClickEveryOddOption()
        {
            new Actions(Driver)
                .Click(Item1Element)
                .Click(Item3Element)
                .Click(Item5Element)
                .Click(Item7Element)
                .Build()
                .Perform();

            return this;
        }

        public string GetMessage() => MessageElement.Text;

        public MySelectablePage SwitchToSelf()
        {
            Driver.SwitchTo().DefaultContent();

            return this;
        }
    }
}
