using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class TicketContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusDescription> BusDescriptions { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Depart> Departs { get; set; }

        public DbSet<Counter> Counters { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDescription> VehicleDescriptions { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}
