using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class TicketInitializer : DropCreateDatabaseIfModelChanges<TicketContext>
    {
        protected override void Seed(TicketContext context)
        {
            //initialize User table
            var users = new List<User>
            {
                new User {UserName = "Pavel",Email = "pavel99nstu@gmail.com",
                    Address = "Road no:1,House Number:1,Sector:6,Uttara,Dhaka",
               PhoneNumber = "01814463576"},
               

            };
            foreach (var temp in users)
            {
                context.Users.Add(temp);

            }
            context.SaveChanges();

             //initialize Bus table
            var buses = new List<Bus>
            {
                new Bus {BusName = "Green Line"},
                new Bus {BusName = "Satr line"},
                new Bus {BusName = "Asia Classic"},

            };
            foreach (var temp in buses)
            {
                context.Buses.Add(temp);
            }
            context.SaveChanges();

            //initialize BusDescription table
            var busdescriptions = new List<BusDescription>
            {
                new BusDescription {PlateNumber = "DHAKA-D-11-9999",BusType = "AC",TotalSeat = 40,},
                

            };
            foreach (var temp in busdescriptions)
            {
                context.BusDescriptions.Add(temp);

            }
            context.SaveChanges();

            //Initialize Route Table
            var departToPlaces = new List<Route>
            {
                new Route {DepartTo = "Dhaka",DepartFrom ="Chittagong"},
               

            };
            foreach (var temp in departToPlaces)
            {
                context.Routes.Add(temp);

            }
            context.SaveChanges();

            //initialize Counter table
            var counters = new List<Counter>
            {
                new Counter {CounterName = "Sydabad"},
              
            };
            foreach (var temp in counters)
            {
                context.Counters.Add(temp);

            }
            context.SaveChanges();

            //initialize Seat table
            var seats = new List<Seat>
            {
                new Seat {SeatName = "A1"},
               
            };
            foreach (var temp in seats)
            {
                context.Seats.Add(temp);

            }
            context.SaveChanges();

            //initialize Ticket table
            var tickets = new List<Ticket>
            {
                new Ticket {TicketNumber = 9999},
                new Ticket {TicketNumber = 9995},
               
            };
            foreach (var temp in tickets)
            {
                context.Tickets.Add(temp);

            }
            context.SaveChanges();

            //initialize Depart table
            var departs = new List<Depart>
            {
               
                new Depart { FarePerSeat = 800.00},
               
            };
            foreach (var temp in departs)
            {
                context.Departs.Add(temp);

            }
            context.SaveChanges();

            //initialize Vehicle table
            var vehicles = new List<Vehicle>
            {
               
                new Vehicle {VehicleType = "Micro Bus"},
               
            };
            foreach (var temp in vehicles)
            {
                context.Vehicles.Add(temp);

            }
            context.SaveChanges();


            //initialize VehicleDescription table
            var vehicleDescriptions = new List<VehicleDescription>
            {
                new VehicleDescription {PlateNumber = "DHAKA-D-12-9999"},
               
               
            };
            foreach (var temp in vehicleDescriptions)
            {
                context.VehicleDescriptions.Add(temp);

            }
            context.SaveChanges();


            //initialize order table
            var orders = new List<Order>
            {
               
                new Order {PickLoaction = "Uttara , Dhaka"},
               
            };
            foreach (var temp in orders)
            {
                context.Orders.Add(temp);

            }
            context.SaveChanges();




        }
        
    }

}