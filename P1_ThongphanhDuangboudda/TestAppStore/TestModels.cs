using System;
using Xunit;
using ModelLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TestAppStore
{
    public class TestModels
    {
        public TestModels()
        {
        }
        /// <summary>
        /// This Test method test creation of Custmer model
        /// </summary>

        [Fact]
        public void Test()
        {
            //Arrang
            Customer customer = new Customer();
            ValidationContext context = new ValidationContext(customer);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(customer, context, results, true);
            Assert.False(valid);
            Assert.True(true);
            Assert.Equal(2, results.Count);
        }
        /// <summary>
        /// This TesCartModel test if Cart model is created.
        /// </summary>
        /// 
        [Fact]
        public void TestCartModel()
        {
            Cart cart = new Cart();
            ValidationContext context = new ValidationContext(cart);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(cart, context, results, true);

            Assert.True(valid);
            Assert.Empty(results);       

        }
        /// <summary>
        /// This TestProductsModel method test if the model create collectly
        /// and the require data annotation validation is working correctly
        /// </summary>
        ///
        [Fact]
        public void TestProductsModel()
        {
            Product product = new Product();
            ValidationContext context = new ValidationContext(product);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(product, context, results,  true);

            Assert.False(valid);
            Assert.Equal(3, results.Count);

        }

        /// <summary>
        /// This TestStoreModel test creation of Stroe model
        /// it returns true since there is no require fields in the model
        /// </summary>
        ///
        [Fact]
        public void TestStoreModel()
        {
            Store store = new Store();
            ValidationContext context = new ValidationContext(store);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(store, context, results, true);

            Assert.True(valid);
            Assert.Empty(results);

        }
        /// <summary>
        /// 
        /// </summary>
        ///
        [Fact]
        public void TestOrderHistor()
        {
            OrderHistory orderHistory = new OrderHistory();
            ValidationContext context = new ValidationContext(orderHistory);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(orderHistory, context, results, true);

            Assert.True(valid);
            Assert.Empty(results);
        }
    }
}
