using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Domain.Models
{
    public class TblUserBooking
    {
        public int UsbId { get; set; }
        public DateTime? BookDate { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? EmailAddress { get; set; }
        public string? MobNox { get; set; }
        public string? Location { get; set; }
    }
}
