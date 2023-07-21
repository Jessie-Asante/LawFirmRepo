using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.Command.DeleteRequest
{
    public class DeleteAboutCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

}
