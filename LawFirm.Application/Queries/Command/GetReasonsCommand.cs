using LawFirm.Application.BaseDtos.QueryDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Queries.Command
{
    public class GetReasonsCommand:IRequest<ReasonsDto>
    {
        public int Id { get; set; }
    }
}
