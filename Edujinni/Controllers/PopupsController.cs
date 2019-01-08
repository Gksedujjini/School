using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class PopupsController : Controller
    {
        // GET: Popups
        public ActionResult DeleteStudentPopup()
        {
            return View();
        }
        public ActionResult TeacherDeletePopup()
        {
            return View();
        }
        public ActionResult ExamScheduleDeletePopup()
        {
            return View();
        }
        public ActionResult EventAddPopup()
        {
            return View();
        }
        public ActionResult ProfileEditPopup()
        {
            return View();
        }
        public ActionResult ExamAdded()
        {
            return View();
        }
        public ActionResult TimeTable()
        {
            return View();
        }
        public ActionResult StudentAdded()
        {
            return View();
        }
        public ActionResult TeacherAdded()
        {
            return View();
        }
        public ActionResult Notification()
        {
            return View();
        }
    }
}