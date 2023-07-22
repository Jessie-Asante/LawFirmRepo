using AutoMapper;
using LawFirm.Application.Commands.Requests.CreateRequest;
using LawFirm.Domain.Models;
using LawFirm.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.CommandHandlers.CreateHandlers
{
    public class CreateReasonsHandler : IRequestHandler<CreateReasonsCommand, int>
    {
        private readonly IGenericRepository<TblReasonsTag> _repo;
        private readonly IMapper _mapper;
        public CreateReasonsHandler(IGenericRepository<TblReasonsTag> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateReasonsCommand request, CancellationToken cancellationToken)
        {
            var dto = request.create;
            var entity = new TblReasonsTag();
            _mapper.Map(dto, entity);
            FormattableString query = $"Exec [dbo].[spcInsertReasonsTags] @Comments ={request.create.Comments}";
            var response = await _repo.Add(query);
            return response;
        }
    }
}
