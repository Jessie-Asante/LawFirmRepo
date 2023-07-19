using LawFirm.Application.Queries.Command;
using LawFirm.Application.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LawFirm.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LawFirmController : ControllerBase
    {
      private readonly IHttpContextAccessor _contextAccessor;
      private readonly IMediator _mediator;
        public LawFirmController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
                _mediator = mediator;
                _contextAccessor = httpContextAccessor;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllBookings()
        {
            var response = _mediator.Send(new GetUserBookingCommand { });
            return Ok(response);
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetHomeById([FromQuery] int Id)
        {
            var response = _mediator.Send(new GetHomeTagCommand {Id=Id });
            return Ok(response);
        } 
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetAboutById([FromQuery] int Id)
        {
            var response = _mediator.Send(new GetAboutTagCommand {Id=Id });
            return Ok(response);
        } 
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetReasonsById([FromQuery] int Id)
        {
            var response = _mediator.Send(new GetReasonsCommand {Id=Id });
            return Ok(response);
        } 
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetServicesById([FromQuery] int Id)
        {
            var response = _mediator.Send(new GetServicesTagCommand {Id=Id });
            return Ok(response);
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetBookingDate([FromQuery] int Id)
        {
            var response = _mediator.Send(new GetBookingCommand { Id=Id});
            return Ok(response);
        }
    }
}
