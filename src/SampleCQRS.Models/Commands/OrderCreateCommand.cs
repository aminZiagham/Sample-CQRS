using MediateR;
using SampleCQRS.Models.Dto;

namespace SampleCQRS.Models.Commands
{
    public class ProductCreateCommand: IRequest<ProductResult> 
    {
        public Guid Id { get; set; }

        public ProductCreateCommand(Guid id)
        {
            this.Id = id;
        }
    }
}