using AutoMapper;
using LawFirm.Application.BaseDtos.QueryDtos;
using LawFirm.Application.Queries.Requests;
using LawFirm.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.Queries.Handlers
{
    public class GetBookingHandler:IRequestHandler<GetBookingCommand, BookingDto>
    {
        private readonly IGenericRepository<BookingDto> _repo;
        private readonly IMapper _mapper;
        public GetBookingHandler(IGenericRepository<BookingDto>repo, IMapper mapper)
        {
                _repo = repo;
            _mapper = mapper;
        }

        public async Task<BookingDto> Handle(GetBookingCommand request, CancellationToken cancellationToken)
        {
            FormattableString query = $"[dbo].[spcGetBookingTime] @BktId={request.Id}";
            var response = await _repo.Get(query);
            return _mapper.Map<BookingDto>(response);
        }
    }
}
