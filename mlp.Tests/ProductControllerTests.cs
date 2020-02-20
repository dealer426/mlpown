//using System;
//using System.Collections.Generic;
//using System.Text;
//using Xunit;
//using Microsoft.AspNetCore.Mvc;
//using mlp.Controllers;
//using mlp.Models;
//using mlp.Repositories;

//namespace mlp.Tests
//{
//    public class ProductControllerTests
//    {
//        ProductController productRepo;

//        public ProductControllerTests(IRepository<Product> productRepo)
//        {
//            this.productRepo = productRepo;
//        }

//        [Fact]
//        public void Index_Returns_View()
//        {
//            //act
//            var result = controller.Index();

//            //assert
//            Assert.IsType<ViewResult>(result);
//        }

//        [Fact]
//        public void Index_Passes_All_ProductModels_To_View()
//        {
//            //act
//            var result = controller.Index();

//            //assert
//            Assert.IsAssignableFrom<IEnumerable<Product>>(result.Model);
//        }

//        [Fact]
//        public void Detail_Returns_View()
//        {
//            //act
//            var result = controller.Detail(1);

//            //assert
//            Assert.IsType<ViewResult>(result);

//        }

//        [Fact]
//        public void Details_Passes_ProductModel_To_View()
//        {
//            //act
//            var result = controller.Detail(1);

//            //assert
//            Assert.IsType<Product>(result.Model);
//        }

//    }
//}
