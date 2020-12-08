using MediateR;
using SampleCQRS.Models.Dto;

namespace SampleCQRS.Models.Queries
{
    public class QueriesHandler: IRequestHandler<ProductQueryById, ProductResult> 
    {
        private readonly ProductService productService;

        public QueriesHandler()
        {
            this.productService = new ProductService();
        }

       public async Task<OrderData> Handle(ProductQueryById request, CancellationToken cancellationToken)
        {
            var result = this.productService.FindById(request.Id);
            return result;
        }
    }
}