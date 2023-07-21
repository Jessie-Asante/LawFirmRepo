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
    public class GetUserBookingHandler:IRequestHandler<GetUserBookingCommand,IEnumerable<UserBookingDto>>
    {
        private readonly IGenericRepository<UserBookingDto> _repo;
        private readonly IMapper _mapper;
        public GetUserBookingHandler(IGenericRepository<UserBookingDto>repo, IMapper mapper)
        {
                _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserBookingDto>> Handle(GetUserBookingCommand request, CancellationToken cancellationToken)
        {
            string query = $"Exec [dbo].[spcGetUserBooking]";
            var response = await _repo.GetAllAsync(query);
            return _mapper.Map<IEnumerable<UserBookingDto>>(response);
        }
    }
}
