using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Moq;
using Thrive.Core.Models;
using Thrive.UseCases.AdminPortal.ManageProducts;
using Thrive.UseCases.PluginInterfaces.DataStore;
using Thrive.UseCases.SearchProduct;
using Thrive.UseCases.ViewProduct;
using Xunit;

namespace Thrive.Tests.ProductTests
{
    public class ProductTest
    {
        private Mock<IProductRepository> _mockProductRepository;

        public ProductTest()
        {
            // Common setup
            _mockProductRepository = new Mock<IProductRepository>();
          
        }

        [Fact]
        public void GetProduct_WithTwoProducts_ReturnsTwoProducts()
        {
            var product = new ObservableCollection<Product>()
            {
                new Product
                {
                    ProductId = 295,
                    Brand = "maybelline",
                    Price = 16.99,
                    Image = Encoding.ASCII.GetBytes(
                        "https://d3t32hsnjxo7q6.cloudfront.net/i/201350fd3e173307ade44520dc87d8fb_ra,w158,h184_pa,w158,h184.png"),
                    Description = "let's you create looks from day to night. Deep to light",
                    Name = "Maybelline The Nudes Eye Shadow Palette"
                },
                new Product
                {
                    ProductId = 307,
                    Brand = "maybelline",
                    Price = 16.99,
                    Image = Encoding.ASCII.GetBytes(
                        "https://d3t32hsnjxo7q6.cloudfront.net/i/201350fd3e173307ade44520dc87d8fb_ra,w158,h184_pa,w158,h184.png"),
                    Description = "let's you create looks from day to night. Deep to light",
                    Name = "Eyestudio"
                }
            };
            _mockProductRepository.Setup(p => p.GetProducts(null)).Returns(product);
            var service = new SearchProduct(_mockProductRepository.Object);
            var result = service.Execute(null);
            Assert.Equal(product.Count, result.Count);


        }

        [Fact]
        public void SaveProduct_NewProduct_AddsProduct()
        {
            // Arrange
            var product = new Product
            {
                ProductId = 2,
                Brand = "maybelline",
                Price = 16.99,
                Image = Encoding.ASCII.GetBytes(
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/201350fd3e173307ade44520dc87d8fb_ra,w158,h184_pa,w158,h184.png"),
                Description = "let's you create looks from day to night. Deep to light",
                Name = "Eyestudio"
            };


            _mockProductRepository.Setup(p => p.CreateProduct(It.IsAny<Product>())).Returns(product);


            var service = new ManageProduct(_mockProductRepository.Object);

            // Act
            var result = service.Execute(product);
            // Assert
            Assert.Equal(product.ProductId, result.ProductId);

            _mockProductRepository.Verify(p => p.CreateProduct(It.IsAny<Product>()), Times.Once);
            _mockProductRepository.Verify(p => p.UpdateProduct(It.IsAny<Product>()), Times.Never);
        }

        [Fact]
        public void SaveProduct_ExistinProduct_UpdatesProduct()
        {
            // Arrange
            var product = new Product
            {
                ProductId = 295,
                Brand = "maybelline",
                Price = 17.99,
                Image = Encoding.ASCII.GetBytes(
                    "https://d3t32hsnjxo7q6.cloudfront.net/i/201350fd3e173307ade44520dc87d8fb_ra,w158,h184_pa,w158,h184.png"),
                Description = "let's you create looks from day to night. Deep to light",
                Name = "Eyestudio"
            };

            _mockProductRepository.Setup(p => p.UpdateProduct(It.IsAny<Product>())).Returns(product);


            var service = new ManageProduct(_mockProductRepository.Object);

            // Act
            var result = service.UpdateProduct(product);
            // Assert
            Assert.Equal(product.ProductId, result.ProductId);
            Assert.Equal(17.99,result.Price);

            _mockProductRepository.Verify(p => p.UpdateProduct(It.IsAny<Product>()), Times.Once);
            _mockProductRepository.Verify(p => p.CreateProduct(It.IsAny<Product>()), Times.Never);
        }


        [Fact]
        public void DeleteProduct_Existing_ReturnsTrue()
        {
            // Arrange

            var productId = 295;
            _mockProductRepository.Setup(p => p.DeleteProduct(It.IsAny<int>())).Returns(true);


            var service = new ManageProduct(_mockProductRepository.Object);

            // Act
            var result = service.DeleteProduct(productId);
            // Assert
            Assert.True(result);
            
            _mockProductRepository.Verify(p => p.DeleteProduct(It.IsAny<int>()), Times.Once);

        }
    }
}
