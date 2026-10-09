using Application.Features.MediatorDesignPattern.Commands.OrderCommands;
using Application.Features.MediatorDesignPattern.Commands.ProfileCommands;
using Application.Features.MediatorDesignPattern.Queries.OrderQueries;
using Application.Features.MediatorDesignPattern.Queries.ProfileQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
      
            private readonly IMediator _mediator;

            public OrdersController(IMediator mediator)
            {
                _mediator = mediator;
            }

            [HttpGet]
            public async Task<IActionResult> GetOrder()
            {

                var value = await _mediator.Send(new GetOrderQuery());
                return Ok(value);
            }
            [HttpPost]
            public async Task<IActionResult> CreateOrder(CreateOrderCommand command)
            {

                await _mediator.Send(command);
                return Ok("Ekleme işlemi başarılı");

            }
            [HttpPut]
            public async Task<IActionResult> UpdateOrder(UpdateOrderCommand command)
            {

                await _mediator.Send(command);
                return Ok("Güncelleme işlemi başarılı");

            }
            [HttpDelete]

            public async Task<IActionResult> DeleteOrder(int id)
            {

                await _mediator.Send(new RemoveOrderCommand(id));

                return Ok("Silme işlemi başarılı");



            }
            [HttpGet("GetOrderById")]
            public async Task<IActionResult> GetOrderById(int id)
            {


                var value = await _mediator.Send(new GetOrderByIdQuery(id));
                return Ok(value);

            }
        }
}
