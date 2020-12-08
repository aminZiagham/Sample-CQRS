using MediateR;
using SampleCQRS.Models.Dto;

namespace SampleCQRS.Models
{
    public class CommandHandler: IRequestHandler<OrderCommand, OrderCreateResult> 
    {

    }
}