using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime StarDateTime { get; set; }
        public DateTime EnDateTime { get; set; }
        public string PickLoaction { get; set; }
      
        public string DropLocation { get; set; }
        public virtual User User { get; set; }
    }


}
