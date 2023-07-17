using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Domain.Models
{
    public class TblAboutTag
    {
        public int AbtId { get; set; }
        public byte[]? Image { get; set; }
        public string ImageHeader { get; set; }
        public string Caption { get; set; }
    }
}
