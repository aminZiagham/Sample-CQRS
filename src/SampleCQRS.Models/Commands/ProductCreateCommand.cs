using MediatR;
using SampleCQRS.Models.Services;

namespace SampleCQRS.Models.Commands
{
    public class ProductCreateCommand: IRequest<Product> 
    {
        public string Name { get; set; }

        public ProductCreateCommand(string name)
        {
            this.Name = name;
        }
    }
}