using ConsoleApp.WebDriver.Pages.Lesson7IFrame;
using System;
using static ConsoleApp.WebDriver.AppSettings.SettingsCongfigurator;

namespace ConsoleApp.WebDriver
{

    class Program : BaseTest
    {
        private static readonly string url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson7;
        static void Main(string[] args)
        {


            try
            {
                var url = AppDomain.CurrentDomain.BaseDirectory + Settings.Urls.UrlLesson7;

                IFramePage iframePage = NavigateTo<IFramePage>(url);
                //MyFramePage myFramePage = NavigateTo<MyFramePage>(url);

                SecondFramePage secondFramePage = iframePage.SwitchToSecondFrame();

                string name = iframePage.GetNameTextField().Split(": ")[1];

                Out.WriteLine($"Name: {name}");

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



