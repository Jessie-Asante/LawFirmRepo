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
    public class DeleteBookingHandlers : IRequestHandler<DeleteBookingCommand, bool>
    {
        private readonly IGenericRepository<CommandBookingDto> _repository;
        private readonly IMapper _mapper;

        public DeleteBookingHandlers(IGenericRepository<CommandBookingDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
        {
            FormattableString query = $"[dbo].[spcDeleteBooking] @BktId ={request.Id}";
            var response = await _repository.Delete(query);
            if (response == 0)
                return false;
            return true;
        }
    }

}
