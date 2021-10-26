using ConsoleApp.WebDriver.Drivers;

namespace ConsoleApp.WebDriver
{
    class Program
    {
        static void Main(string[] args)
        {

            WebDriverManager.Driver.Navigate().GoToUrl("https://google.com");
            WebDriverManager.DisposeDriver();


        }
    }
}
