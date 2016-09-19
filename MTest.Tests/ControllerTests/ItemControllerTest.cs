using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MTest.Controllers;
using MTest.Models;
using MTest.Services;
using Xunit;

namespace MTest.Tests.ControllerTests
{
    public class ItemControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            AuthController controller = new AuthController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }

}
