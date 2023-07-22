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
    public class UpdateAboutHandler : IRequestHandler<UpdateAboutCommand, Unit>
    {
        private readonly IGenericRepository<TblAboutTag> _genericRepository;
        private readonly IMapper _mapper;

        public UpdateAboutHandler(IGenericRepository<TblAboutTag> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var dto = request.update;
            var entity = new TblAboutTag();
            _mapper.Map(dto, entity);
            FormattableString query = $"[dbo].[spcUpdateAboutTags] @AbtId = {request.Id}, @Image = {request.update.Image}, @ImageHeader = {request.update.ImageHeader}, @Caption = {request.update.Caption}";
            var response = await _genericRepository.Update(query);
            return Unit.Value;
        }
    }

}
