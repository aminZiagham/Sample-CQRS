using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SampleCQRS.Models.Services 
{
    public class ProductService
    {
        private readonly List<Product> productRepository;

        #region contructors
        public ProductService()
        {
            productRepository = new List<Product>();
            productRepository.AddRange(TestInitialize());
        }
        #endregion

        #region private methods
        private IEnumerable<Product> TestInitialize(){
            var _products = new List<Product>();
            Product product = null;

            product = Product.Add(Guid.Parse("9743ea71-b19a-4477-b6e9-30a50614115d"), 
            "Product 1", DateTime.Now);
            _products.Add(product);

            product = Product.Add(Guid.Parse("1a6053f9-5752-46b5-8989-4b851dd84d0b"),
            "Product 2", DateTime.Now);
            _products.Add(product);

            product = Product.Add(Guid.Parse("e649777c-7433-4363-9cdf-88f92e006560"),
            "Product 3", DateTime.Now);
            _products.Add(product);

            return _products;
        }
        #endregion

        #region  public methods
        public Task<Product> AddProduct(string productName)
        {
            var product = Product.Add(Guid.NewGuid(), productName, DateTime.Now);
            productRepository.Add(product);
            return Task.FromResult(product);
        }

        public Task<Product> FindById(Guid id)
        {
            var result = productRepository.Where(p=>p.Id == id).FirstOrDefault();
            return Task.FromResult(result);
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            var result = productRepository.AsEnumerable();
            return Task.FromResult(result);
        }
        #endregion
    }
}