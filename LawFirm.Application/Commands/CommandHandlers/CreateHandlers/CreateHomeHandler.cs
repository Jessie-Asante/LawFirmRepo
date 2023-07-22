using AutoMapper;
using LawFirm.Application.BaseDtos.CommandDtos;
using LawFirm.Application.Commands.Requests.CreateRequest;
using LawFirm.Domain.Models;
using LawFirm.Infrastructure.Persistence;
using MediatR;

namespace LawFirm.Application.Commands.CommandHandlers.CreateHandlers
{
    public class CreateHomeHandler : IRequestHandler<CreateHomeCommand, int>
    {
        private readonly IGenericRepository<TblHomeTag> _repo;
        private readonly IMapper _mapper;

        public CreateHomeHandler(IGenericRepository<TblHomeTag> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateHomeCommand request, CancellationToken cancellationToken)
        {
            var dto = request.create;
            var entity = new TblHomeTag();
            _mapper.Map(dto, entity);
            FormattableString query = $"Exec [dbo].[spcInsertHomeTag] @Image = {request.create.Image}, @ImageHeader = {request.create.ImageHeader}, @Caption = {request.create.Caption}";
            var response = await _repo.Add(query);

            return response;
        }
    }
}