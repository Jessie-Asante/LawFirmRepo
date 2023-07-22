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
    public class DeleteReasonsHandlers : IRequestHandler<DeleteReasonsCommand, bool>
    {
        private readonly IGenericRepository<CommandReasonsDto> _repository;
        private readonly IMapper _mapper;

        public DeleteReasonsHandlers(IGenericRepository<CommandReasonsDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteReasonsCommand request, CancellationToken cancellationToken)
        {
            FormattableString query = $"[dbo].[spcDeleteReasonsTag] @RstId ={request.Id}";
            var response = await _repository.Delete(query);
            if (response == 0)
                return false;
            return true;
        }
    }


}
