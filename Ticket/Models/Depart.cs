using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class Depart
    {
        public int Id { get; set; }
        public DateTime DeparTime { get; set; }
        public DateTime ArriveTime { get; set; }
        public double FarePerSeat { get; set; }

        public int AvailableSeats { get; set; }
        
        public virtual BusDescription BusDescription { get; set; }
        
        public virtual Route Route { get; set; }
    }
}