using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SampleCQRS.Models.Services 
{
    public class ProductService
    {
        private readonly List<Product> productRepository;

        public ProductService()
        {
            productRepository = new List<Product>();
        }

        public AddProduct(string productName)
        {
            var product = Product.Add(Guid.NewGuid, productName, DateTime.Now);
            productRepository.Add(product);
        }

        public IEnumerable<Product> FindById(Guid id)
        {
            return productRepository.Where(p->p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.Tolist();
        }
    }
}