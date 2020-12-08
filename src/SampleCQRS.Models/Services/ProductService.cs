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

        public ProductService()
        {
            productRepository = new List<Product>();
        }

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
    }
}