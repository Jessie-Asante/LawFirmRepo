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
    public class GetServicesTagHandler : IRequestHandler<GetServicesTagCommand, ServicesDto>
    {
        private readonly IGenericRepository<ServicesDto> _repo;
        private readonly IMapper _mapper;
        public GetServicesTagHandler(IGenericRepository<ServicesDto> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ServicesDto> Handle(GetServicesTagCommand request, CancellationToken cancellationToken)
        {
            string query = $"[dbo].[spcGetServiceTags] @SvtId ={request.Id}";
            var response = await _repo.GetById(query);
            return _mapper.Map<ServicesDto>(response);
        }
    }

}
