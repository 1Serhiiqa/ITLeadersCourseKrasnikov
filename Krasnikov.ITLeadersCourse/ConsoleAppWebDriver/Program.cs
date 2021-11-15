using ConsoleApp.WebDriver.Appendix.HomeTasks.Lesson6_AdditionalWindows;
using ConsoleApp.WebDriver.Helpers;
using System;
using static ConsoleApp.CSharpBasics.IO.Output;

namespace ConsoleApp.WebDriver
{

    class Program : BaseTest
    {

        static void Main(string[] args)
        {



            try
            {
                var additionalWindowPage = NavigateTo<AdditionalWindowPage>(AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson6);
                var additionalWindowPageHandle = WindowHelper.AddWindow();

                var automationPracticePage = MessageWindowPage.ClickNewMessageWindowLink();
                //var automationPracticePage = AdditionalWindowPage.ClickNewMessageWindowLink();
                var automationPracticePageHandle = WindowHelper.AddWindow();
                WindowHelper.SwitchTo(automationPracticePageHandle);



                //var firstWindowPage = NavigateTo<FirstWindowPage>(AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson6);
                //var secondWindowPage = firstWindowPage.ClickSecondPageLink();
                //var thirdWindowPage = secondWindowPage.ClickThirdPageLink();
                //var message = thirdWindowPage.GetMessage();

                //Out.WriteLine($"Message: {message}");

                var message = NewBrowserTabText.GetNewBrowserTabText();

                Out.WriteLine($"Message: {message}");
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





