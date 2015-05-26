using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class BusDescription
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public string BusType { get; set; }
        public int TotalSeat { get; set; }

        public virtual Bus Bus { get; set; }
    }
}