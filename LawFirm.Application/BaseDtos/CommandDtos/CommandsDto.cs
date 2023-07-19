using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Application.BaseDtos.CommandDtos
{
    public class CommandsDto
    {
    }

    public class CommandHomesDto
    {
        public byte[]? Image { get; set; }
        public string? ImageHeader { get; set; }
        public string? Caption { get; set; }
    }
    public class CommandReasonsDto
    {
        public int RstId { get; set; }
        public string Comments { get; set; }
    } 
    public class CommandAboutDto
    {
        public byte[]? Image { get; set; }
        public string? ImageHeader { get; set; }
        public string? Caption { get; set; }
    }
    public class CommandServicesDto
    {
        public int SvtId { get; set; }
        public string Header { get; set; }
        public string Comments { get; set; }
    } 
    public class CommandBookingDto
    {
        public int BktId { get; set; }
        public DateTime dtpDate { get; set; }
    }
    public class CommandUserBookingDto
    {
        public DateTime BookDate { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string EmailAddress { get; set; }
        public string MobNox { get; set; }
        public string Location { get; set; }
    }
}
