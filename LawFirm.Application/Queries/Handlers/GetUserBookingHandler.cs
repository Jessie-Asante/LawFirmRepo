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
    public class GetUserBookingHandler:IRequestHandler<GetUserBookingCommand,IReadOnlyList<UserBookingDto>>
    {
        private readonly IGenericRepository<IReadOnlyList<UserBookingDto>> _repo;
        private readonly IMapper _mapper;
        public GetUserBookingHandler(IGenericRepository<IReadOnlyList<UserBookingDto>>repo, IMapper mapper)
        {
                _repo = repo;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<UserBookingDto>> Handle(GetUserBookingCommand request, CancellationToken cancellationToken)
        {
            string query = ($"[dbo].[spcGetUserBooking]");
            var response = await _repo.GetAllAsync(query);
            return _mapper.Map<IReadOnlyList<UserBookingDto>>(response);
        }
    }
}
