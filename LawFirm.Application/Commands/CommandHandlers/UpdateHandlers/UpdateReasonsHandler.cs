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
    public class UpdateReasonsHandler : IRequestHandler<UpdateReasonsCommand, Unit>
    {
        private readonly IGenericRepository<TblReasonsTag> _genericRepository;
        private readonly IMapper _mapper;

        public UpdateReasonsHandler(IGenericRepository<TblReasonsTag> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateReasonsCommand request, CancellationToken cancellationToken)
        {
            var dto = request.update;
            var entity = new TblReasonsTag();
            _mapper.Map(dto, entity);
            string query = $"[dbo].[spcUpdateReasonsTags] @RstId = {request.Id}, @Comments = {request.update.Comments}";
            var response = await _genericRepository.Update(query);
            return Unit.Value;
        }
    }

}
