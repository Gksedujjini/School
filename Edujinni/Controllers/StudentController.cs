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
        public ActionResult StudentDashboard()
        {
            return View();
        }
        public ActionResult EditProfile()
        {
            return View();
        }
        public ActionResult student()
        {
            return View();
        }
        public ActionResult editstudent()
        {
            return View();
        }
        public ActionResult AcademicSyallabus()
        {
            return View();
        }
        public ActionResult TimeTable()
        {
            return View();
        }
        public ActionResult Diary()
        {
            return View();
        }
        public ActionResult LeadingBoard()
        {
            return View();
        }
        public ActionResult Attendance()
        {
            return View();
        }
        public ActionResult Events()
        {
            return View();
        }
        public ActionResult ExamSchedule()
        {
            return View();
        }
        public ActionResult ViewExamSchedule()
        {
            return View();
        }
        public ActionResult Overview()
        {
            return View();
        }
        
        public ActionResult test()
        {
            ViewBag.Message = "hello..this is test";
            return View();
        }
        public ActionResult Marks()
        {
            return View();
        }
        public ActionResult CompareMarks()
        {
            return View();
        }
        public ActionResult Assignments()
        {
            return View();
        }
        public ActionResult Messages()
        {
            return View();
        }
        public ActionResult SendMessage()
        {
            return View();
        }
        public ActionResult LeaveRequest()
        {
            return View();
        }
        public ActionResult ApplyLeave()
        {
            return View();
        }
        public ActionResult StudentAchievements()
        {
            return View();
        }
      
    }
}