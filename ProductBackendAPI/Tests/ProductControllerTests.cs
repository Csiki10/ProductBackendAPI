using Microsoft.AspNetCore.Mvc;
using ProductBackendAPI.Controllers;
using ProductBackendAPI.Models;

namespace ProductBackendAPI.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Get_ReturnsListOfProducts()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<ProductController>>();
            var controller = new ProductController(mockLogger.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsType<List<Product>>(result);
        }

        [Fact]
        public void Get_ReturnsNotFoundForNonexistentId()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<ProductController>>();
            var controller = new ProductController(mockLogger.Object);

            // Act
            var result = controller.Get("nonexistentId");

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}

