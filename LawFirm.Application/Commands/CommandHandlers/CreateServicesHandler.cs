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

namespace LawFirm.Application.Commands.CommandHandlers
{
    public class CreateServicesHandler:IRequestHandler<CreateServiceCommand, int>
    {
        private readonly IGenericRepository<TblServiceTag> _repo;
        private readonly IMapper _mapper;
        public CreateServicesHandler(IGenericRepository<TblServiceTag> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var dto = request.create;
            var entity = new TblServiceTag();
            _mapper.Map(dto, entity);
            string query = ($"[dbo].[spcInsertServicesTag] @Header = {request.create.Header}, @Comments ={request.create.Comments}");
            var response = await _repo.AddAsync(query);
            return response;
        }
    }

   
}
