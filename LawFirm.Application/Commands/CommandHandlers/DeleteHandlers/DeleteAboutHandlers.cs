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
    public class DeleteAboutHandlers : IRequestHandler<DeleteAboutCommand, bool>
    {
        private readonly IGenericRepository<CommandAboutDto> _repository;
        private readonly IMapper _mapper;

        public DeleteAboutHandlers(IGenericRepository<CommandAboutDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteAboutCommand request, CancellationToken cancellationToken)
        {
            FormattableString query = $"[dbo].[spcDeleteAboutTag] @AbtId ={request.Id}";
            var response = await _repository.Delete(query);
            if (response == 0)
                return false;
            return true;
        }
    }

}
