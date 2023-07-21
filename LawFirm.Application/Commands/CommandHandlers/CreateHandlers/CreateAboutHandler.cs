using AutoMapper;
using LawFirm.Application.BaseDtos.CommandDtos;
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
    public class CreateAboutHandler : IRequestHandler<CreateAboutCommand, int>
    {
        private readonly IGenericRepository<TblAboutTag> _repo;
        private readonly IMapper _mapper;
        public CreateAboutHandler(IGenericRepository<TblAboutTag> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            var dto = request.create;
            var entity = new TblAboutTag();
            _mapper.Map(dto, entity);
            string query = $"[dbo].[spcInsertHomeTag] @Image = {request.create.Image}, @ImageHeader = {request.create.ImageHeader}, @Caption = {request.create.Caption}";
            var response = await _repo.AddAsync(query);
            return response;
        }
    }
}
