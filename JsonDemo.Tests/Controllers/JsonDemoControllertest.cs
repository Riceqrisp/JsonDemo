using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonResultDemo.Controllers;

namespace JsonResultDemo.Tests.Controllers
{
    [TestClass]
    public class JsonDemoControllerTest
    {
        [TestMethod]
        public void WelcomeNote()
        {
            JsonDemoController controller = new JsonDemoController();

            JsonResult result = controller.WelcomeNote();
            string msg = Convert.ToString(result.Data);
            // Assert  
            Assert.AreEqual("Welcome to the User", msg);
        }
    }
}