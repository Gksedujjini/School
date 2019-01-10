using Edujinni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddAchievements()
        {
            return View();
        }
        public ActionResult ViewAchievements()
        {
            return View();
        }
        public ActionResult EditProfile()
        {
            return View();
        }
        public ActionResult AddSubjects()
        {
            return View();
        }
        public ActionResult AddSubjectView()
        {
            return View();
        }
        public ActionResult ViewClass()
        {
            return View();
        }
        public ActionResult AddClass()
        {
            return View();
        }
        public ActionResult ATTRecords()
        {
            return View();
        }

        //ALL TIMETABLE CONTROLLERS  GOES HERE ////
        public ActionResult ViewTimeTable()
        {
            return View();
        }
        public ActionResult AddTimeTable()
        {
            return View();
        }
        public ActionResult AttendanceView()
        {
            return View();
        }
        public ActionResult AddStudent()
        {
            return View();
        }
        //STUDENTS OVERVIEW MODULE //
        public ActionResult StudentsOverView()
        {
            return View();
        }
        public ActionResult StudentInfo()
        {
            return View();
        }
        /// TEACHER MODULE ///
        public ActionResult TeacherView()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddTeacher(Addteacher addTech)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.edujinni.in/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();
            addTech.insert_by = "ganesh";
            addTech.insert_date = DateTime.Now;
            addTech.update_by = "gani";
            addTech.update_date = DateTime.Now;
            addTech.class_id = 1;
            addTech.school_id = 1;

            HttpResponseMessage response = await client.PostAsJsonAsync("addingTeacher", addTech);
            if (response.IsSuccessStatusCode == true)
            {
                Response.Cookies.Clear();
                ModelState.Clear();
                return View();
            }

            return View(addTech);
        }

        public ActionResult TeacherInfo()
        {
            return View();
        }
        //teacher module ends here
        //USE IT FOR THE TESTING OF PAGES PURPOSE WHILE BUILDING IF REQUIRED
        public ActionResult test()
        {
            return View();
        }
        public ActionResult test2()
        {
            return View();
        }
        public ActionResult AddResultView()
        {
            return View();
        }
        public ActionResult AddLeadingBoard()
        {
            return View();
        }
        public ActionResult LeadingBoardView()
        {
            return View();
        }
        public ActionResult TeacherEditProfileView()
        {
            return View();
        }
        public ActionResult NewLayout()
        {
            return View();
        }

    }
}