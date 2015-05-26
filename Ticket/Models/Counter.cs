using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class Counter
    {
        public int Id { get; set; }
        public string CounterName { get; set; }
        public string Address { get; set; }
        public DateTime BoardingTime { get; set; }


        public virtual BusDescription BusDescription { get; set; }

        public virtual User User { get; set; }
    }
}