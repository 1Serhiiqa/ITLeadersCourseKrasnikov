using ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson7_IFrame;
using ConsoleApp.WebDriver.Pages.Lesson7IFrame;
using System;
using static ConsoleApp.CSharpBasics.IO.Output;
using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

namespace ConsoleApp.WebDriver
{

    class Program : BaseTest
    {
        private static readonly string url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson7;
        static void Main(string[] args)
        {
            string expectedMessage = "Welcome: John Smith";

            try
            {
                //var url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson7;

                //IFramePage iframePage = NavigateTo<IFramePage>(url);

                //1.Go to Frame 2
                MyFramePage myFramePage = NavigateTo<MyFramePage>(url);

                SecondFramePage secondFramePage = myFramePage.SwitchToSecondFrame();


                //2.Go to Frame 1

                //SecondFramePage secondFramePage = NavigateTo<SecondFramePage>(url);

                ThirdFramePage thirdFramePage = secondFramePage.SwitchToThirdFrame();


                //3. Get Name
                string name = thirdFramePage.GetNameTextField().Split(": ")[1];

                //4.Return to Frame 2
                thirdFramePage.SwitchToSecondFrame();


                //5. Get Last Name
                string lastName = secondFramePage.GetLastNameTextField().Split(": ")[1];

                //6. Return to IFramePage window
                secondFramePage.SwitchToMyFramePage();

                //7. Input Full name into input field (in format John Smith)
                var fullUserName = "FullUserName($"Name: { name}
                " + "LastName: { lastName}
                ");
                var FullUserName($"Name: {name}" + "LastName: {lastName}");

                //var submitPage = formPage.ClickSubmitButton();
                //var submitMessage = submitPage.GetSubmitMessage();

                //AssertThatSubmitMessageIsCorrect(expectedMessage, submitMessage);

                //8. Click Check button

                myFramePage.ClickCheckUserNameButton();

                //9. Get result and compare it with your one
                var resultMessage = myFramePage.GetResultMessage().Split(": ");
                Out.WriteLine(fullUserName);
                // compare are fullUserName & resultMessage
                // expectedMessage
            }
            catch (Exception)
            {


            }


            finally
            {
                DisposeTest();
            }
        }

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



