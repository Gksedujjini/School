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

        /// TEACHER MODULE ///
        public ActionResult TeacherView()
        {
            return View();
        }
        public ActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddTeacher(Addteacher teacher)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52995/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();

            HttpResponseMessage response = await client.PostAsJsonAsync("addingTeacher", teacher);

            if (response.IsSuccessStatusCode == true)
            {
                Response.Cookies.Clear();
                ModelState.Clear();
                return View();
            }
            return View(teacher);
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

        //LEADING BOARD
        public ActionResult LeadingBoardView()
        {
            return View();
        }
        public ActionResult AddLeadingBoard()
        {
            return View();
        }
    }
}