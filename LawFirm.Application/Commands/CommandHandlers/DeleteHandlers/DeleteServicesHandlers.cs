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
    public class DeleteServicesHandlers : IRequestHandler<DeleteServiceCommand, bool>
    {
        private readonly IGenericRepository<CommandServicesDto> _repository;
        private readonly IMapper _mapper;

        public DeleteServicesHandlers(IGenericRepository<CommandServicesDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
        {
            FormattableString query = $"[dbo].[spcDeleteServiceTag] @SvtId ={request.Id}";
            var response = await _repository.Delete(query);
            if (response == 0)
                return false;
            return true;
        }
    }


}
