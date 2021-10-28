using ConsoleApp.WebDriver.Drivers;
using System;

namespace ConsoleApp.WebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = AppDomain.CurrentDomain.BaseDirectory + @"\Appendix\Lessons\Lesson2_WebDriverIntroduction\index.html";

            WebDriverManager.Driver.Navigate().GoToUrl(url);
            WebDriverManager.DisposeDriver();


        }
    }

}





