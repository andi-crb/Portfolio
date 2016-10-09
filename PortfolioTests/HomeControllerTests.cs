using System.Web.Mvc;
using Portfolio;
using Portfolio.Controllers;
using Portfolio.Models;
using Xunit;

namespace PortfolioTests
{
    //public class HomeControllerTests
    //{
    //    [Fact]
    //    public void Index()
    //    {
    //        // Arrange
    //        var controller = new HomeController();

    //        // Act
    //        var result = controller.Index() as ViewResult;

    //        // Assert
    //        Assert.NotNull(result);
    //    }
    //}
    public class HistoryTests
    {
        [Fact]
        public void HistoryReceivesViewModel()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.History() as ViewResult;
            var model = result?.Model as HistoryViewModel;

            // Assert
            Assert.NotNull(model);
        }
    }
}