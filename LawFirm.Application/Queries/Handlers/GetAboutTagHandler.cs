using AutoMapper;
using LawFirm.Application.BaseDtos.QueryDtos;
using LawFirm.Application.Queries.Command;
using LawFirm.Application.Queries.Requests;
using LawFirm.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Queries.Handlers
{
    public class GetAboutTagHandler:IRequestHandler<GetAboutTagCommand, AboutDto>
    {
        private readonly IGenericRepository<AboutDto> _repo;
        private readonly IMapper _mapper;
        public GetAboutTagHandler(IGenericRepository<AboutDto> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<AboutDto> Handle(GetAboutTagCommand request, CancellationToken cancellationToken)
        {
            string query = $"[dbo].[spcGetAboutTag] @AbtIdpk ={request.Id}";
            var response = await _repo.GetById(query);
            return _mapper.Map<AboutDto>(response);
        }
    }
}
