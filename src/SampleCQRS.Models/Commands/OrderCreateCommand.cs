using MediateR;
using SampleCQRS.Models.Dto;

namespace SampleCQRS.Models.Commands
{
    public class OrderCommand: IRequest<ProductResult> 
    {
        public Guid Id { get; set; }

        public OrderCommand(Guid id)
        {
            this.Id = id;
        }
    }
}