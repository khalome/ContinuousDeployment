using Microsoft.VisualStudio.TestTools.UnitTesting;
using continuousweb.Controllers;

namespace continuousweb.tests
{
    [TestClass]
    public class HomeControllerTests
    {        
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
