using LawFirm.Application.BaseDtos.CommandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.Command.UpdateCommand
{
    public class UpdateBookingCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public CommandBookingDto update { get; set; }
    }

}
