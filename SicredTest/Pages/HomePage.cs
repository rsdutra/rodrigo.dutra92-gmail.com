using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SicredTest.Pages
{
    public class HomePage
    {
        public IWebDriver driver;
        public IWebElement profileForYou { get; set; }
        public IWebElement profileForCompany { get; set; }
        public IWebElement initialvalue { get; set; }
        public IWebElement monthValue { get; set; }
        public IWebElement time { get; set; }
        public IWebElement period { get; set; }
        
        public IWebElement simulate { get; set; }

        string BaseUrl = "";
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            
        }
        public void MapFields()
        {
            profileForYou = driver.FindElement(By.CssSelector("[value='paraVoce']"));
            profileForCompany = driver.FindElement(By.CssSelector("[value='paraEmpresa']"));
            initialvalue = driver.FindElement(By.Id("valorAplicar"));
            monthValue = driver.FindElement(By.Id("valorInvestir"));
            time = driver.FindElement(By.Id("tempo"));
            period = driver.FindElement(By.Id("periodo"));
            simulate = driver.FindElement(By.CssSelector("[class*='btnSimular']"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="period">
        /// M = month
        /// A = Year
        /// </param>
        public void ChangePeriod(string period)
        {
            driver.FindElement(By.CssSelector("[class='seta']")).Click();
            driver.FindElement(By.CssSelector("[rel='"+period+"']")).Click();
        }
    }
}
