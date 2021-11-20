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
