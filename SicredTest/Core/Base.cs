using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace SicredTest.Core
{
    public abstract class Base
    {
        public IWebDriver driver;
        string baseUrl;
        public RestClient client;
        public Base()
        {
        }

        protected abstract void InitializeReferences();

        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
            baseUrl = "https://www.sicredi.com.br/html/ferramenta/simulador-investimento-poupanca/";
            driver.Url = baseUrl;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            client = new RestClient(baseUrl);
            InitializeReferences();
        }
        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }
        
    }
}
