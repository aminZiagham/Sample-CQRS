using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SampleCQRS.Models.Services;

namespace SampleCQRS.Models.Queries
{
    public class QueriesHandler: 
        IRequestHandler<ProductQueryById, Product>,
        IRequestHandler<ProductsListQuery, IEnumerable<Product>> 
    {
        private readonly ProductService productService;

        public QueriesHandler()
        {
            this.productService = new ProductService();
        }

        public Task<IEnumerable<Product>> Handle(ProductsListQuery request, CancellationToken cancellationToken)
        {
            return this.productService.GetProducts();
        }

        public Task<Product> Handle(ProductQueryById request, CancellationToken cancellationToken)
        {
            var result = this.productService.FindById(request.Id);
            return result;
        }
    }
}