using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Handlers;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase {

        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices]IMediator mediator, 
            [FromBody]CreateCustomerRequest command
        ){
            return mediator.Send(command);
        }

        
        [HttpGet]
        [Route("")]
        public IActionResult Get(){
            return Ok("teste");
        }
    }
}