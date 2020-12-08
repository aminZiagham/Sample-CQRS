using MediateR;
using SampleCQRS.Models.Dto;

namespace SampleCQRS.Models.Queries
{
    public class QueriesHandler: IRequestHandler<ProductQuery, ProductResult> 
    {
        private readonly ProductService productService;

        public OrderQueryHandler()
        {
            this.productService = new ProductService();
        }

       public async Task<OrderData> Handle(ProductQuery request, CancellationToken cancellationToken)
        {
            var result = this.productService.FindById(request.Id);
            return result;
        }
    }
}