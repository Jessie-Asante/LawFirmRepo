using LawFirm.Application.BaseDtos.CommandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.Command.UpdateRequest
{
    public class UpdateAboutCommand:IRequest<Unit>
    {
        public int Id { get; set; }
        public CommandAboutDto update { get; set; }
    }
}
