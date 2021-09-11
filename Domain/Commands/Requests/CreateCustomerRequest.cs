using MediatR;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Nome { get; set; }
        public string Email { get; set; }

    }
}