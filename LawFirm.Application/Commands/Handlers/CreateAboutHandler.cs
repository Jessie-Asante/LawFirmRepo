using AutoMapper;
using LawFirm.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.Handlers
{
    public class CreateAboutHandler:IRequestHandler<CreateAboutRequest, int>
    {
        private readonly IGenericRepository<TblAboutTag> _repo;
        private readonly IMapper _mapper;
        public CreateAboutHandler(IGenericRepository<TblAboutTag> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
    }
}
