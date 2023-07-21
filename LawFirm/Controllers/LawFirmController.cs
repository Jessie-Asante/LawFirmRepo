using LawFirm.Application.BaseDtos.CommandDtos;
using LawFirm.Application.Commands.Command.DeleteRequest;
using LawFirm.Application.Commands.Command.UpdateCommand;
using LawFirm.Application.Commands.Command.UpdateRequest;
using LawFirm.Application.Commands.Requests.CreateRequest;
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
      private readonly IMediator _mediator;
        public LawFirmController(IMediator mediator)
        {
                _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllBookings()
        {
            var response =await _mediator.Send(new GetUserBookingCommand { });
            return Ok(response);
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetHomeById([FromQuery] int Id)
        {
            var response =await _mediator.Send(new GetHomeTagCommand {Id=Id });
            return Ok(response);
        } 
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetAboutById([FromQuery] int Id)
        {
            var response =await _mediator.Send(new GetAboutTagCommand {Id=Id });
            return Ok(response);
        } 
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetReasonsById([FromQuery] int Id)
        {
            var response =await _mediator.Send(new GetReasonsCommand {Id=Id });
            return Ok(response);
        } 
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetServicesById([FromQuery] int Id)
        {
            var response =await _mediator.Send(new GetServicesTagCommand {Id=Id });
            return Ok(response);
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetBookingDate([FromQuery] int Id)
        {
            var response =await _mediator.Send(new GetBookingCommand { Id=Id});
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateHomeTag([FromBody] CommandHomesDto homeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new CreateHomeCommand { create=homeDto });
                return Ok(response);
            }
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateAboutTag([FromBody] CommandAboutDto aboutDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new CreateAboutCommand { create=aboutDto });
                return Ok(response);
            }
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateReasonsTag([FromBody] CommandReasonsDto reasonDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new CreateReasonsCommand { create=reasonDto });
                return Ok(response);
            }
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateBookingDate([FromBody] CommandBookingDto reasonDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new CreatingBookingCommand { create=reasonDto });
                return Ok(response);
            }
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateServicesTag([FromBody] CommandServicesDto serviceDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new CreateServiceCommand { create= serviceDto });
                return Ok(response);
            }
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateUserBooking([FromBody] CommandUserBookingDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new CreateUserBookingCommand { create=userDto });
                return Ok(response);
            }
        }
        
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateUserBooking([FromBody] CommandUserBookingDto userDto, [FromQuery]int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new UpdateUserBookingCommand { 
                    update=userDto,
                    Id=Id
                });
                return Ok(response);
            }
        }
        
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateBookingDate([FromBody] CommandBookingDto bookDto, [FromQuery]int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new UpdateBookingCommand { 
                    update=bookDto,
                    Id=Id
                });
                return Ok(response);
            }
        } 
        
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateHomeTag([FromBody] CommandHomesDto homeDto, [FromQuery]int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new UpdateHomeCommand { 
                    update=homeDto,
                    Id=Id
                });
                return Ok(response);
            }
        } 
        
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateAboutTag([FromBody] CommandAboutDto aboutDto, [FromQuery]int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new UpdateAboutCommand { 
                    update=aboutDto,
                    Id=Id
                });
                return Ok(response);
            }
        }
        
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateServiceTag([FromBody] CommandServicesDto serviceDto, [FromQuery]int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new UpdateServicesCommand { 
                    update=serviceDto,
                    Id=Id
                });
                return Ok(response);
            }
        }
        
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdateReasonsTag([FromBody] CommandReasonsDto reasonDto, [FromQuery]int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(); 
            }
            else
            {
                var response =await _mediator.Send(new UpdateReasonsCommand { 
                    update=reasonDto,
                    Id=Id
                });
                return Ok(response);
            }
        }
        
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteHomeTag([FromQuery]int Id)
        {
            var response = await _mediator.Send(new GetHomeTagCommand { Id=Id });
            if (response==null)
            {
                return BadRequest(); 
            }
            else
            {
                var result =await _mediator.Send(new DeleteHomeCommand { 
                    
                    Id=Id
                });
                return Ok(result);
            }
            
        }
        
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteAboutTag([FromQuery]int Id)
        {
            var response = await _mediator.Send(new GetAboutTagCommand { Id=Id });
            if (response==null)
            {
                return BadRequest(); 
            }
            else
            {
                var result =await _mediator.Send(new DeleteAboutCommand { 
                    
                    Id=Id
                });
                return Ok(result);
            }
            
        }
        
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteReasonsTag([FromQuery]int Id)
        {
            var response = await _mediator.Send(new GetReasonsCommand { Id=Id });
            if (response==null)
            {
                return BadRequest(); 
            }
            else
            {
                var result =await _mediator.Send(new DeleteReasonsCommand { 
                    
                    Id=Id
                });
                return Ok(result);
            }
            
        }
        
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteServiceTag([FromQuery]int Id)
        {
            var response = await _mediator.Send(new GetServicesTagCommand { Id=Id });
            if (response==null)
            {
                return BadRequest(); 
            }
            else
            {
                var result =await _mediator.Send(new DeleteServiceCommand { 
                    
                    Id=Id
                });
                return Ok(result);
            }
            
        } 
        
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteBookingDate([FromQuery]int Id)
        {
            var response = await _mediator.Send(new GetBookingCommand { Id=Id });
            if (response==null)
            {
                return BadRequest(); 
            }
            else
            {
                var result =await _mediator.Send(new DeleteBookingCommand { 
                    
                    Id=Id
                });
                return Ok(result);
            }
            
        }
        
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteUserBooking([FromQuery]int Id)
        {
                var result =await _mediator.Send(new DeleteUserBookingCommand { 
                    
                    Id=Id
                });
                return Ok(result);
            
        }
    }
}
