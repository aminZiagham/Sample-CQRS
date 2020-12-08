using MediateR;
using SampleCQRS.Models.Dto;

namespace SampleCQRS.Models.Queries
{
    public class QueriesHandler: 
        IRequestHandler<ProductQueryById, ProductResult>,
        IRequestHandler<ProductsListQuery, IEnumerable<ProductResult>> 
    {
        private readonly ProductService productService;

        public QueriesHandler()
        {
            this.productService = new ProductService();
        }

        public async Task<IEnumerable<ProductResult>> Handle(ProductsListQuery request, CancellationToken cancellationToken)
        {
            return this.productService.GetProducts();
        }

        public async Task<OrderData> Handle(ProductQueryById request, CancellationToken cancellationToken)
        {
            var result = this.productService.FindById(request.Id);
            return result;
        }
    }
}