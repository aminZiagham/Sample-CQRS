using System;
using MediatR;
using SampleCQRS.Models.Services;

namespace SampleCQRS.Models.Queries
{
    public class ProductQueryById: IRequest<Product> 
    {
        public Guid Id { get; set; }

        public ProductQueryById(Guid id)
        {
            this.Id = id;
        }
    }
}