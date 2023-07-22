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
    public class CreateUserBookingHandler : IRequestHandler<CreateUserBookingCommand, int>
    {
        private readonly IGenericRepository<TblUserBooking> _repo;
        private readonly IMapper _mapper;
        public CreateUserBookingHandler(IGenericRepository<TblUserBooking> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateUserBookingCommand request, CancellationToken cancellationToken)
        {
            var dto = request.create;
            var entity = new TblUserBooking();
            _mapper.Map(dto, entity);
            FormattableString query = $"Exec [dbo].[spcInsertUserBooking] @BookDate = {request.create.BookDate}, @FName = {request.create.FName}, @LName = {request.create.LName}, @EmailAddress = {request.create.EmailAddress}, @MobNox = {request.create.MobNox}, @Locations = {request.create.Location}";
            var response = await _repo.Add(query);
            return response;
        }
    }
}
