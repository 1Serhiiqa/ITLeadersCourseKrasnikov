using ConsoleApp.WebDriver.Pages.Lesson6AdditionalWindows;
using System;
using static ConsoleApp.CSharpBasics.IO.Output;
using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

namespace ConsoleApp.WebDriver
{

    class Program : BaseTest
    {

        static void Main(string[] args)
        {



            try
            {
                var firstWindowPage = NavigateTo<FirstWindowPage>(AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson6);
                var secondWindowPage = firstWindowPage.ClickSecondPageLink();
                var thirdWindowPage = secondWindowPage.ClickThirdPageLink();
                var message = thirdWindowPage.GetMessage();

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





