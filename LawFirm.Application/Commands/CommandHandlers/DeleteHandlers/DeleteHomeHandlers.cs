using AutoMapper;
using LawFirm.Application.BaseDtos.CommandDtos;
using LawFirm.Application.Commands.Command.DeleteRequest;
using LawFirm.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.CommandHandlers.DeleteHandlers
{
    public class DeleteHomeHandlers:IRequestHandler<DeleteHomeCommand, bool>
    {
        private readonly IGenericRepository<CommandHomesDto> _repository;
        private readonly IMapper _mapper;

        public DeleteHomeHandlers(IGenericRepository<CommandHomesDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteHomeCommand request, CancellationToken cancellationToken)
        {
            string query = $"[dbo].[spcDeleteHomeTag] @HmtID ={request.Id}";
            var response = await _repository.DeleteAsync(query);
            if (response==false)
                return false;
            return true;
        }
    }
}
