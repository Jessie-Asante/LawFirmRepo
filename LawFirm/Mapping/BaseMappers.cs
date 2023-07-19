using AutoMapper;
using LawFirm.Application.BaseDtos.CommandDtos;
using LawFirm.Domain.Models;

namespace LawFirm.Api.Mapping
{
    public class BaseMappers:Profile
    {
        public BaseMappers()
        {
                CreateMap<CommandHomesDto, TblHomeTag>().ReverseMap();
                CreateMap<CommandBookingDto, TblBookingTag>().ReverseMap();
                CreateMap<CommandAboutDto, TblAboutTag>().ReverseMap();
                CreateMap<CommandReasonsDto, TblReasonsTag>().ReverseMap();
                CreateMap<CommandServicesDto, TblServiceTag>().ReverseMap();
                CreateMap<CommandUserBookingDto, TblUserBooking>().ReverseMap();
        }
    }
}
