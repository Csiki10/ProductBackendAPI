using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ProductBackendAPI.Controllers;
using ProductBackendAPI.Models;
using System.Collections.Generic;

namespace ProductBackendAPI.Tests
{
    [TestFixture]
    public class ProductControllerTests
    {
        [Test]
        public void Get_ReturnsListOfProducts()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<ProductController>>();
            var controller = new ProductController(mockLogger.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.That(result, Is.InstanceOf<List<Product>>());
        }

        [Test]
        public void Get_ReturnsNotFoundForNonexistentId()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<ProductController>>();
            var controller = new ProductController(mockLogger.Object);

            // Act
            var result = controller.Get("nonexistentId");

            // Assert
            Assert.That(result, Is.InstanceOf<NotFoundResult>());
        }
    }
}
