using AutoMapper;
using LawFirm.Application.Commands.Command.UpdateCommand;
using LawFirm.Application.Commands.Command.UpdateRequest;
using LawFirm.Domain.Models;
using LawFirm.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.CommandHandlers.UpdateHandlers
{
    public class UpdateBookingHandler : IRequestHandler<UpdateBookingCommand, Unit>
    {
        private readonly IGenericRepository<TblBookingTag> _genericRepository;
        private readonly IMapper _mapper;

        public UpdateBookingHandler(IGenericRepository<TblBookingTag> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
        {
            var dto = request.update;
            var entity = new TblBookingTag();
            _mapper.Map(dto, entity);
            string query = $"[dbo].[spcUpdateBookingTags] @BktId = {request.Id}, @dtpDate = {request.update.dtpDate}";
            var response = await _genericRepository.Update(query);
            return Unit.Value;
        }
    }

}
