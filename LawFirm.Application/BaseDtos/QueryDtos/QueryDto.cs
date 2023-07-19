using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.BaseDtos.QueryDtos
{
    public class QueryDto
    {
       

    }

    public class UserBookingDto
    {
        public int UsbId { get; set; }
        public DateTime BookDate { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string EmailAddress { get; set; }
        public string MobNox { get; set; }
        public string Locations { get; set; }
    }
    public class ServicesDto
    {
        public int SvtId { get; set; }
        public string Header { get; set; }
        public string Comments { get; set; }
    }
    public class ReasonsDto
    {
        public int RstId { get; set; }
        public string Comments { get; set; }
    } 
    public class HomeDto
    {
        public int HmtId { get; set; }
        public byte[]? Image { get; set; }
        public string? ImageHeader { get; set; }
        public string? Caption { get; set; }
    }
    public class BookingDto
    {
        public int BktId { get; set; }
        public DateTime dtpDate { get; set; }
    } 
    public class AboutDto
    {
        public int AbtIdpk { get; set; }
        public byte[]? Image { get; set; }
        public string? ImageHeader { get; set; }
        public string? Caption { get; set; }
    }

}
