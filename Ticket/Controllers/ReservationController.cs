using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticket.Models;

namespace Ticket.Controllers
{   
    public class ReservationController : Controller
    {
       
        TicketContext db=new TicketContext();
        //
        // GET: /Reservation/
        public ActionResult Index()
        {
           // IEnumerable<SearchingData> views =null;
            //views.RouteData = (from r in db.Routes select r).ToList();
            //views.DepartData = (from d in db.Departs select d).ToList();

           //views  = (from r in db.Routes join d in db.Departs on r.Id equals d.Route

           //          select new
           //          {
           //              DepartTo = r.DepartTo,
           //              DepartFrom = r.DepartFrom,
           //              DepartTime = d.DeparTime
           //          }
           // );


           
           return View();
        }

        public ActionResult ShowBusSchedule()
        {
            return View();
        }
	}
}