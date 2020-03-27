using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SicredTest.Pages
{
    public class ResultPage
    {
        public IWebDriver driver;
        public IWebElement mainValue { get; set; }
        public IWebElement table { get; set; }

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void MapFields()
        {
            mainValue = driver.FindElement(By.CssSelector("[class='valor']"));
            table = driver.FindElement(By.CssSelector("table tbody tr"));
        }
    }
}
