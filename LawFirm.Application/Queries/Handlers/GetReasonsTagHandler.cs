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
    public class GetReasonsTagHandler : IRequestHandler<GetReasonsCommand, ReasonsDto>
    {
        private readonly IGenericRepository<ReasonsDto> _repo;
        private readonly IMapper _mapper;
        public GetReasonsTagHandler(IGenericRepository<ReasonsDto> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ReasonsDto> Handle(GetReasonsCommand request, CancellationToken cancellationToken)
        {
            string query = $"[dbo].[spcGetReasonsTags] @RstId ={request.Id}";
            var response = await _repo.GetById(query);
            return _mapper.Map<ReasonsDto>(response);
        }
    }

}
