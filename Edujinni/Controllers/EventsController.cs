using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult EvetsView()
        {
            return View();
        }
        public ActionResult AddEventsView()
        {
            return View();
        }
    }
}