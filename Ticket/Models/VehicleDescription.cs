using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class VehicleDescription
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public int NumberOfSeat { get; set; }
        public string Brand { get; set; }
        public double FarePerday { get; set; }
        public string PhotoUrl { get; set; }

        public string PhoneNumber { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}