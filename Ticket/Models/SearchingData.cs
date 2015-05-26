using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class SearchingData
    {
        public string DepartTo { get; set; }
        public string DepartFrom { get; set; }

        public DateTime DepartTime { get; set; }
    }
}