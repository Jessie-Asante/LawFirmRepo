using AutoMapper;
using LawFirm.Application.Commands.Command.UpdateCommand;
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
    public class UpdateServicesHandler : IRequestHandler<UpdateServicesCommand, Unit>
    {
        private readonly IGenericRepository<TblServiceTag> _genericRepository;
        private readonly IMapper _mapper;

        public UpdateServicesHandler(IGenericRepository<TblServiceTag> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateServicesCommand request, CancellationToken cancellationToken)
        {
            var dto = request.update;
            var entity = new TblServiceTag();
            _mapper.Map(dto, entity);
            string query = $"[dbo].[spcUpdateServicesTags] @SvtId = {request.Id}, @Header = {request.update.Header}, @Comments = {request.update.Comments}";
            var response = await _genericRepository.Update(query);
            return Unit.Value;
        }
    }

}
