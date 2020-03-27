using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SicredTest.Core;
using RestSharp;
using System.Net;
using SicredTest.WorkFlow;

namespace SicredTest
{
    [TestClass]
    public class SicredTest : Base
    {
        protected HomeWorkFlow homeWorkFlow;

        protected override void InitializeReferences()
        {
            homeWorkFlow = new HomeWorkFlow(driver);
        }

        [TestMethod]
        [Owner("Rodrigo Dutra")]
        [TestCategory("RegressionTest")]
        public void TC_UpAndRunning()
        {
            RestRequest request = new RestRequest();
            IRestResponse response =  client.ExecuteAsGet(request,"GET");
            Assert.IsTrue(response.StatusCode == HttpStatusCode.OK, "Page not loaded successfully");
        }

        [TestMethod]
        [Owner("Rodrigo Dutra")]
        [TestCategory("Happy Path Simulate")]
        public void TC_PopulateFieldCorectly()
        {
            try
            {
                homeWorkFlow.FillFieldsAndSimulate("2000","2000");
                Assert.IsTrue(true, "Simulation done with success");
            }
            catch(Exception ex)
            {
                Assert.Fail("An error occurred: "+ex.Message);
            }   
        }

        [TestMethod]
        [Owner("Rodrigo Dutra")]
        [TestCategory("Wrong Path simulate")]
        public void TC_PopulateFieldWrong()
        {
            try
            {
                homeWorkFlow.FillFieldsAndSimulate("1500","2000");
                Assert.Fail("Simulation done with success with wrong values");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true,"With wrong values field are not aviable, message:" + ex.Message);
            }
        }
    }
}
