using AutoMapper;
using LawFirm.Application.BaseDtos.QueryDtos;
using LawFirm.Application.Queries.Command;
using LawFirm.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Queries.Handlers
{
    public class GetHomeTagHandler : IRequestHandler<GetHomeTagCommand, HomeDto>
    {
        private readonly IGenericRepository<HomeDto> _repo;
        private readonly IMapper _mapper;
        public GetHomeTagHandler(IGenericRepository<HomeDto> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<HomeDto> Handle(GetHomeTagCommand request, CancellationToken cancellationToken)
        {
            string query = $"[dbo].[spcGetHomeTag] @HmtId ={request.Id}";
            var response = await _repo.GetById(query);
            return _mapper.Map<HomeDto>(response);
        }
    }

}
