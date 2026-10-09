using Application.Features.MediatorDesignPattern.Commands.ProfileCommands;
using Application.Features.MediatorDesignPattern.Queries.ProfileQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public  ProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfile()
        {

            var value = await _mediator.Send(new GetProfileQuery());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateProfileCommand command)
        {

            await _mediator.Send(command);
            return Ok("Ekleme işlemi başarılı");

        }
        [HttpPut]
        public async Task<IActionResult> UpdateProfile(UpdateProfileCommand command)
        {

            await _mediator.Send(command);
            return Ok("Güncelleme işlemi başarılı");

        }
        [HttpDelete]

        public async Task<IActionResult> DeleteProfile(int id)
        {

            await _mediator.Send(new RemoveProfileCommand(id));

            return Ok("Silme işlemi başarılı");



        }
        [HttpGet("GetProfileById")]
        public async Task<IActionResult> GetProfileById(int id)
        {


            var value = await _mediator.Send(new GetProfileByIdQuery(id));
            return Ok(value);

        }
    }
}
