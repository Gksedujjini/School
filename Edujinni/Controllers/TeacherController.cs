using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult SyllabusView()
        {
            return View();
        }
        public ActionResult AddSyllabusView()
        {
            return View();
        }
        public ActionResult DiaryView()
        {
            return View();
        }
        public ActionResult AddDiary()
        {
            return View();
        }
    }
}