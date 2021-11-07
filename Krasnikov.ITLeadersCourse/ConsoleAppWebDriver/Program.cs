using ConsoleApp.WebDriver.Pages.Lesson4Select;
using System;
using System.Collections.Generic;
using static ConsoleApp.CSharpBasics.IO.Output;

namespace ConsoleApp.WebDriver
{

    class Program : BaseTest
    {
        public readonly static string url = AppDomain.CurrentDomain.BaseDirectory
            + @"\Appendix\Lessons\Lesson4_Select\select.html";

        static void Main(string[] args)
        {
            SelectPage selectPage = NavigateTo<SelectPage>(url);

            //1. In Multiple select make a selection of 3 options.
            List<string> optionsToBeSelected = ("Mike", "Jane", "Scott");

            //2. Get all selected options and check them out if they are all as expected.
            selectPage.GetSelectedOptionsFromMultipleSelect(optionsToBeSelected);

            var actualOption = selectPage.GetSelectedOptionsFromMultipleSelect();

            Out.WriteLine($"Expected option: {optionToBeSelected}; Actual option: {actualOption}");




            try
            {




                //3. Deselect one option in the multiple select.
                selectPage.DeelectedOptionsFromMultipleSelect("Mike");

                //4. Get left options form Multiple select and check them if they are as expected.
                selectPage.GetSelectedOptionsFromMultipleSelect(optionsToBeSelected);

                var actualOption = selectPage.GetSelectedOptionsFromMultipleSelect();

                Out.WriteLine($"Expected option: {optionToBeSelected}; Actual option: {actualOption}");

                //5.Deselect all options in the multiple select.
                selectPage.DeelectedAllOptionsFromMultipleSelect();

                //6.Check out that all options were deselected.
                selectPage.GetSelectedOptionsFromMultipleSelect(optionsToBeSelected);

                var actualOption = selectPage.GetSelectedOptionsFromMultipleSelect();

                Out.WriteLine($"Expected option: {optionToBeSelected}; Actual option: {actualOption}");

                selectPage.
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





