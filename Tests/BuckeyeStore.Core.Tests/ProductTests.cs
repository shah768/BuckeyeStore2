using System;
using Xunit;
using BuckeyeStore.Core;

namespace BuckeyeStore.Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var product = new Product
            {
                Id = 1,
                Name = "T-shirt",
                Brand = "nike"
            };
            
            var review = new Review
            {
                Id = 1,
                Body = "A durable Buckeye T-Shirt."
            };
            //Act
            product.AddReview(review);

            //Assert
            Assert.NotNull(product.Review);
            Assert.Equal(review.Id, product.Review.Id);
            Assert.Equal(review.Body, product.Review.Body);
        }
     }
}
