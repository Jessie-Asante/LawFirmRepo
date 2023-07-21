using AutoMapper;
using LawFirm.Application.Commands.Requests.CreateRequest;
using LawFirm.Domain.Models;
using LawFirm.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Commands.CommandHandlers.CreateHandlers
{
    public class CreateBookingHandler : IRequestHandler<CreatingBookingCommand, int>
    {
        private readonly IGenericRepository<TblBookingTag> _repo;
        private readonly IMapper _mapper;
        public CreateBookingHandler(IGenericRepository<TblBookingTag> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatingBookingCommand request, CancellationToken cancellationToken)
        {
            var dto = request.create;
            var entity = new TblBookingTag();
            _mapper.Map(dto, entity);
            string query = $"[dbo].[spcInsertBookingTags] @dtpDate ={request.create.dtpDate}";
            var response = await _repo.AddAsync(query);
            return response;
        }
    }
}
