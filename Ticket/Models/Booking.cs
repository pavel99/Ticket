using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public virtual Available Available { get; set; }
        public virtual User User { get; set; }
        
    }
}