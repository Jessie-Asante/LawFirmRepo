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
    public class DeleteUserBookingHandler : IRequestHandler<DeleteUserBookingCommand, bool>
    {
        private readonly IGenericRepository<CommandUserBookingDto> _repository;
        private readonly IMapper _mapper;

        public DeleteUserBookingHandler(IGenericRepository<CommandUserBookingDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteUserBookingCommand request, CancellationToken cancellationToken)
        {
            string query = $"[dbo].[spcDeleteUserBooking] @UsbId ={request.Id}";
            var response = await _repository.DeleteAsync(query);
            if (response == false)
                return false;
            return true;
        }
    }


}
