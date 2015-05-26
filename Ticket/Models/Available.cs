using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class Available
    {
        public int Id{ get; set; }
        public int Avaiable { get; set; }

        public virtual BusDescription BusDescription { get; set; }
        public virtual Seat Seat { get; set; }
    }
    
}