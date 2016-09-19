using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using MTest.Models;


namespace MTest.Tests
{
    public class ItemTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var item = new Pumpkin();

            //Act
            item.Description = "Wash the dog.";
            var result = item.Description;

            //Assert
            Assert.Equal("Wash the dog.", result);
        }
    }
}
