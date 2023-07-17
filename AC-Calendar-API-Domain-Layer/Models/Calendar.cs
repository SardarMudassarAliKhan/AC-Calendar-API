using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AC_Calendar_API_Domain_Layer.Models
{
    public class Calendar:BaseEntity
    {
        public string display { get; set; }
        public bool startEditable { get; set; }
        public bool durationEditable { get; set; }
        public string overlap { get; set; }
        public string backgroundColor { get; set; }
        public string borderColor { get; set; }
        public string textColor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
