using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_WebApi_Example.Interfaces;
using TDD_WebApi_Example.Model;
using TDD_WebApi_Example.Services;

namespace TDD_WebApi_Example.Tests
{
    public class ProductServiceTests
    {
        private readonly IProductService _sut;
        private readonly Mock<IProductRepository> _mockRepo = new Mock<IProductRepository>();
                
        public ProductServiceTests()
        {
            _sut = new ProductService(_mockRepo.Object);
        }

        [Fact]
        public async Task GetById_ShouldReturnProduct_WhenIdIsValid()
        {
            // Arrange
            var expected = new Product { Id = 1, Name = "Laptop" };
            _mockRepo.Setup(r => r.GetById(1)).Returns(expected);

            // Act
            var result = await _sut.GetById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expected.Id, result.Id);
            Assert.Equal(expected.Name, result.Name);
        }

        [Fact]
        public async Task GetById_ShouldReturnNull_WhenIdIsNotValid()
        {
            // Arrange
            Product? expected = null;
            int id = -1;

            // Act
            var result = await _sut.GetById(id);

            // Assert
            Assert.Null(result);
            Assert.Equal(expected, result);
        }
    }
}
