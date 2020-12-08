using MediateR;
using SampleCQRS.Models.Dto;

namespace SampleCQRS.Models.Queries
{
    public class ProductQueryById: IRequest<ProductResult> 
    {
        public Guid Id { get; set; }

        public ProductQueryById(Guid id)
        {
            this.Id = id;
        }
    }
}