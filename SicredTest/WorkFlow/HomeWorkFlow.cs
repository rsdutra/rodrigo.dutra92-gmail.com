using OpenQA.Selenium;
using SicredTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicredTest.WorkFlow
{
    public class HomeWorkFlow
    {
        IWebDriver driver;
        HomePage homePage;
        ResultPage resultPage;
        public HomeWorkFlow(IWebDriver driver)
        {
            this.driver = driver;
            homePage = new HomePage(driver);
            resultPage = new ResultPage(driver);
        }
        public void FillFieldsAndSimulate(string initialvalue,string monthValue)
        {
            homePage.MapFields();
            homePage.profileForYou.Click();
            homePage.initialvalue.SendKeys(initialvalue);
            homePage.monthValue.SendKeys(monthValue);
            homePage.time.SendKeys("12");
            homePage.ChangePeriod("M");
            homePage.simulate.Click();
            resultPage.MapFields();
        }
    }
}
