using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RIBCCS.Pages
{
    public class DropDownMenuPage 
    {
        IWebDriver driver;
        public readonly string Link = @"https://www.globalsqa.com/demo-site/select-dropdown-menu/";

        public DropDownMenuPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void SelectCountry(string countryName)
        {
            IWebElement element = driver.FindElement(By.CssSelector("select"));
            SelectElement countryDropDown = new SelectElement(element);

            countryDropDown.SelectByText(countryName);
        }
    }
}
