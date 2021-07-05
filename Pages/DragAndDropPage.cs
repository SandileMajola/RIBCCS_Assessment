using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RIBCCS.Pages
{
    public class DragAndDropPage
    {
        IWebDriver driver;
        public readonly string Link = @"https://www.globalsqa.com/demo-site/draganddrop/";

        public DragAndDropPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void DragItem(string item)
        {
            driver.SwitchTo().Frame(1);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement trash = driver.FindElement(By.Id("trash"));
            IWebElement itemToDrag = driver.FindElement(By.XPath(".//div[1]/ul/li[1]"));

            Actions act = new Actions(driver);

            for (int i = 1; i <= 4; i++)
            {
                itemToDrag = driver.FindElement(By.XPath(".//div[1]/ul/li[" + i + "]/h5"));

                if (itemToDrag.Text == item)
                {
                    act.DragAndDrop(itemToDrag, trash).Build().Perform();
                    break;
                }
            }
                     
        }
    }
}
