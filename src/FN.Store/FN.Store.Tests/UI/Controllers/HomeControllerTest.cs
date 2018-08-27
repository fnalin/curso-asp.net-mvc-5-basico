using FN.Store.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace FN.Store.Tests.UI.Controllers
{
    [TestClass, TestCategory("Controllers/HomeController")]
    public class HomeControllerTest
    {

        //dado o HomeController

        [TestMethod]
        public void OMetodoIndexDeveraRetornarUmaView()
        {
            //arrange
            var homeController = new HomeController();

            //act
            var result = homeController.Index();

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }



    }
}
