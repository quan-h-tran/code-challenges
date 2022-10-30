using Microsoft.VisualStudio.TestTools.UnitTesting;
using RSL.CodeChallenge.Controllers;
using RSL.CodeChallenge.Services;
using System.Web.Mvc;

namespace RSL.CodeChallenge.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private ApiService _apiService = new ApiService();

        [TestMethod]
        public void HomePage()
        {
            // Arrange
            HomeController controller = new HomeController(_apiService);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LatestResultsPage()
        {
            // Arrange
            HomeController controller = new HomeController(_apiService);

            // Act
            ViewResult result = controller.LatestResults() as ViewResult;

            // Assert
            Assert.AreEqual("The Lott Lastest Result", result.ViewBag.Title);
        }

        [TestMethod]
        public void LatestResultsPageViewModelNotNull()
        {
            // Arrange
            HomeController controller = new HomeController(_apiService);

            // Act
            ViewResult result = controller.LatestResults() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }
    }
}
