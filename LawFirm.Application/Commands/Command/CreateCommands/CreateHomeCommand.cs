using LawFirm.Application.BaseDtos.CommandDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.Requests.CreateRequest
{
    public class CreateHomeCommand : IRequest<int>
    {
        public CommandHomesDto create { get; set; }
    }
}
