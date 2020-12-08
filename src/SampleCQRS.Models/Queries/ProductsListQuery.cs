using MediatR;
using System.Collections.Generic;
using SampleCQRS.Models.Services;

namespace SampleCQRS.Models.Queries
{
    public class ProductsListQuery: IRequest<IEnumerable<Product>>
    {
        
    }
}