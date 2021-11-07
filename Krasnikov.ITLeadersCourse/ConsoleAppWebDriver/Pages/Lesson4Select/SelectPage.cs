using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;


namespace ConsoleApp.WebDriver.Pages.Lesson4Select
{

    public class SelectPage : BasePage
    {
        private IList<IWebElement> GeneralSelectOptions => FindElements(By.XPath("//select[@id='namesList']/option"));

        private IWebElement GeneralSelect => FindElement(By.CssSelector("select#namesList"));

        private IWebElement GroupedSelect => FindElement(By.CssSelector("select#groupedNames"));

        //HomeTask - locator
        private IWebElement MultipleSelect => FindElement(By.CssSelector("select#multipleNames"));

        public void SelectNameInGeneralSelect(string name)
        {
            foreach (var element in GeneralSelectOptions)
            {
                if (name.Equals(element.Text, StringComparison.OrdinalIgnoreCase))
                {
                    element.Click();
                }
            }
        }

        public string GetSelectedNameInGeneralSelect()
        {
            return GeneralSelect.Text;
        }

        public void SelectOptionInGeneralSelect(string name)
        {
            var select = new SelectElement(GeneralSelect);

            select.SelectByText(name);
        }

        public string GetSelectedOptionInGeneralSelect()
        {
            return new SelectElement(GeneralSelect).SelectedOption.Text;
        }

        public void SelectOptionInGroupedSelect(string name)
        {
            var select = new SelectElement(GroupedSelect);

            select.SelectByText(name);
        }

        public string GetSelectedOptionInGroupedSelect()
        {
            return new SelectElement(GroupedSelect).SelectedOption.Text;
        }

        //HomeTask
        //ver.07.11.21(example line 49)

        //1. In Multiple select make a selection of 3 options.
        //2. Get all selected options and check them out if they are all as expected.
        public void SelectOptionsInMultipleSelect(List<string> names)
        {
            var select = new SelectElement(MultipleSelect);

            select.SelectByText();
        }
        public string GetSelectedOptionsInMultipleSelect()
        {
            return new SelectElement(MultipleSelect).SelectedOption.Text;
        }

        //3. Deselect one option in the multiple select.
        //4. Get left options form Multiple select and check them if they are as expected.
        public void SelectOptionsInMultipleSelect(List<string> names)
        {
            var select = new SelectElement(MultipleSelect);

            select.SelectByText(List<string> names);
        }
        public string GetSelectedOptionsInMultipleSelect()
        {
            return new SelectElement(MultipleSelect).SelectedOption.Text;
        }

        //5. Deselect all options in the multiple select.
        //6. Check out that all options were deselected.

        public void SelectOptionsInMultipleSelect(List<string> names)
        {
            var select = new SelectElement(MultipleSelect);

            select.DeselectAll(List<string> names);
        }
        public string GetSelectedOptionsInMultipleSelect()
        {
            return new SelectElement(MultipleSelect).SelectedOption.Text;
        }


        //ver.05.11.21
        //public void SelectOptionsInMultipleSelect(string name)
        //{
        //    foreach (var element in MultipleSelectOptions- GetSelectedOptionsFromMultipleSelect)
        //    {
        //        if (name.Equals(element.Text, StringComparison.OrdinalIgnoreCase))
        //        {
        //            element.Click();
        //        }
        //    }
        //}
        //public List<string> GetSelectedOptionsFromMultipleSelect()
        //{
        //    var select = new SelectElement(MultipleSelect);

        //    return select.AllSelectedOptions;

        //}

        //public List<string> DeelectedOptionsFromMultipleSelect()
        //{
        //    var deselect = new SelectElement(MultipleSelect);

        //    return select. ;

        //}
    }

}
