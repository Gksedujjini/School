using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult student()
        {
            return View();
        }
        public ActionResult editstudent()
        {
            return View();
        }
        public ActionResult test()
        {
            ViewBag.Message = "hello..this is test";
            return View();
        }
    }
}