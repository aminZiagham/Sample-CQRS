using MediatR;
using System.Threading;
using System.Threading.Tasks;
using SampleCQRS.Models.Services;

namespace SampleCQRS.Models.Commands
{
    public class CommandsHandler: IRequestHandler<ProductCreateCommand, Product> 
    {
        private readonly ProductService productService;

        public CommandsHandler()
        {
            this.productService = new ProductService();
        }

        public Task<Product> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
        {
            var result = this.productService.AddProduct(request.Name);
            return result;
        }
    }
}