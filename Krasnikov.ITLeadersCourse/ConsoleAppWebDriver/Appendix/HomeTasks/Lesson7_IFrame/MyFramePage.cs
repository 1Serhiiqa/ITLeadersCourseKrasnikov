using OpenQA.Selenium;

namespace ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson7_IFrame
{
    //Go to IFramePage
    public class MyFramePage : BasePage
    {
        //1. Go to Frame 2
        private IWebElement SecondFrameElement => FindElement(By.Id("frame2Wrapper"));

        public MyFramePage SwitchToSecondFrame()
        {
            Driver.SwitchTo().Frame(SecondFrameElement);

            return new MyFramePage();
        }

        //2. Go to Frame 1
        private IWebElement ThirdFrameElement => FindElement(By.Id("innerFrame"));

        public MyFramePage SwitchToThirdFrame()
        {
            Driver.SwitchTo().Frame(ThirdFrameElement);

            return new MyFramePage();
        }

        //3. Get Name

        private IWebElement NameTextField => FindElement(By.Id("name"));

        public string GetNameTextField() => NameTextField.Text.Split(": ")[1];



    }
}


//Go to IFramePage
//1. Go to Frame 2
//2. Go to Frame 1
//3. Get Name
//4. Return to Frame 2
//5. Get Last Name
//6. Return to IFramePage window
//7. Input Full name into input (in format John Smith)
//8.Click Check button
//9. Get result and compare it with your one