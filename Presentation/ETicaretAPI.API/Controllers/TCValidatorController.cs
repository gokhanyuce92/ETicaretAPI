using ETicaretAPI.Application.Consts;
using ETicaretAPI.Application.CustomAttributes;
using ETicaretAPI.Application.Enums;
using ETicaretAPI.Application.Features.Queries.TCValidator;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TCValidatorController : ControllerBase
    {
        readonly IMediator Mediator;
        public TCValidatorController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Verify([FromBody] TCValidatorQueryRequest citizen)
        {
            var response = await Mediator.Send(citizen);

            return Ok(response);
        }
    }
}
