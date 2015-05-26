using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string DepartTo { get; set; }
        public string DepartFrom{ get; set; }
       
    }
}