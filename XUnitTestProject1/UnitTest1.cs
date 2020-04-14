using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using webAPI.Controllers;
using webAPI.Domain.Models;
using webAPI.Domain.Services;
using webAPI.Persistance.Contexts;
using webAPI.Services;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {

        
        ProductsController _controller;

        //IProductService _service;
        private readonly ProductServiceFake service;
        private readonly AppDbContext context;

        public UnitTest1()
        {
            IProductService servicee = (IProductService)service;
            _controller = new ProductsController(context, servicee);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetProducts();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetProducts().Result;

            // Assert
            var items = Assert.IsType<List<Product>>(okResult.ToString());
            Assert.Equal(3, items.Count);
        }

       

        

        [Fact]
        public void Test1()
        {
            

        }
    }
}
