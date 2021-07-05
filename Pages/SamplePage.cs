using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RIBCCS.Pages
{
    public class SamplePage
    {

        IWebDriver driver;
        public readonly string Link = @"https://www.globalsqa.com/samplepagetest/";

        public SamplePage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void FillInSamplePage(string name, string email, string website, string experience, string comment)
        {
            IWebElement Name = driver.FindElement(By.XPath("//div[@id='g2599-name']"));
            IWebElement Email = driver.FindElement(By.XPath("//div[@id='g2599-email']"));
            IWebElement Website = driver.FindElement(By.XPath("//div[@id='g2599-website']"));

            IWebElement element = driver.FindElement(By.CssSelector("select"));
            SelectElement Experience = new SelectElement(element);

            IWebElement Comment = driver.FindElement(By.XPath("//div[@id='g2599-website']"));

            Name.SendKeys(name);
            Name.SendKeys(Keys.Tab);
            Email.SendKeys(email);
            Email.SendKeys(Keys.Tab);
            Website.SendKeys(website);

            Experience.SelectByText(experience);

            Comment.SendKeys(comment);
        }

    }
}
