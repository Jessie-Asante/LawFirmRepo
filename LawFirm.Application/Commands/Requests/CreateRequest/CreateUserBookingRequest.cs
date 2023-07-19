using LawFirm.Application.BaseDtos.CommandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.Requests.CreateRequest
{
    public class CreateUserBookingRequest:IRequest<int>
    {
        public CommandUserBookingDto create { get; set; }
    }
}
