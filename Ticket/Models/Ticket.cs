using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int TicketNumber { get; set; }
        public string NumberOfSeat { get; set; }
        public virtual User UserId { get; set; }
        public virtual BusDescription BusDescription { get; set; }
        public virtual Seat Seat { get; set; }
       
    }
}