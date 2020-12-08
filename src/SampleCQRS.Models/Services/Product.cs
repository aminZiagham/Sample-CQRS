using System;

namespace SampleCQRS.Models.Services 
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string ProductName { get; private set; }
        public DateTime CreationDate { get; private set; }

        public static Product Add(Guid id, string productName, DateTime creationDate)
        {
            return new Product
            {
                Id = id,
                ProductName = productName,
                CreationDate = creationDate
            };
        }
    }
}