using MediateR;
using SampleCQRS.Models.Dto;

namespace SampleCQRS.Models.Queries
{
    public class ProductQuery: IRequest<ProductResult> 
    {
        public Guid Id { get; set; }

        public OrderCommand(Guid id)
        {
            this.Id = id;
        }
    }
}