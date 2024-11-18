using Xunit;
using LivLineWeb.Controllers;
using LivLineWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace LivLineWeb.Tests
{
    public class LivLineWebTests
    {
        [Fact]
        public void SimplifyText_ReturnsSimplifiedText()
        {
            // Arrange
            var service = new SimplificationService();
            var controller = new SimplifyController(service);
            var input = "This is a complicated test";

            // Act
            var result = controller.SimplifyText(input) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            var response = result.Value as dynamic;
            Assert.Equal("This is a simple test", response.simplified);
        }
    }
}
