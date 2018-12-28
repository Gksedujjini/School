using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class AttendanceController : Controller
    {
        // GET: Attendance
        public ActionResult AttendanceView()
        {
            return View();
        }
    }
}