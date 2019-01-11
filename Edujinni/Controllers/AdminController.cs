using Edujinni.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
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
        //public async Task<ActionResult> classdetails()
        //{

        //    var model = new classdetails();


        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://localhost:44305/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        ViewBag.country = "";
        //        HttpResponseMessage response = await client.GetAsync("api/v1/doctor/country");
        //        List<string> li;
        //        if (response.IsSuccessStatusCode)
        //        {
        //            Country co = new Models.Country();
        //            li = await response.Content.ReadAsAsync<List<string>>();
        //            ViewBag.country = li;
        //        }
        //    }
        //    return View();
        //}

        public async  Task<ActionResult> AddStudent(addstudent student)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.edujinni.in/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();
            ViewBag.classdetails = "";
            HttpResponseMessage response = await client.GetAsync("classNames/classDetailsList");
            List<string> list;
            //JsonConvert.DeserializeObject<List<addstudent>>(Json);
            if (response.IsSuccessStatusCode ==true)
            {
                //list = await response.Content.ReadAsAsync<List<string>>();
                //ViewBag.classdetails = list;
            }
            student.insert_by = "srikar";
            student.insert_date = DateTime.Now;
            student.update_by = "srikar";
            student.update_date = DateTime.Now;
            student.school_id = 1;
            HttpResponseMessage res = await client.PostAsJsonAsync("addingStudentDetails", student);
            if (res.IsSuccessStatusCode == true)
            {
                Response.Cookies.Clear();
                ModelState.Clear();
                return ViewBag.Message();
            }
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
        public ActionResult AddTeacher()
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
            Console.WriteLine(response);
            if (response.IsSuccessStatusCode == true)
            {
                Response.Cookies.Clear();
                ModelState.Clear();
                return ViewBag.Message();
            }

            return View();
        }
        //public ActionResult AddTeacher()
        //{
        //    return View();
        //}


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
        //public ActionResult AddClass()
        //{
        //    return View();
        //}

        //GET REQUEST
        //public ActionResult AddClass()
        //{
        //    List<addclass> Teacherlist = new List<addclass>();
        //    HttpClient client = new HttpClient();
        //    var result = client.GetAsync("http://www.Edujinni.com/classdetailslist").Result;
        //    if (result.IsSuccessStatusCode)
        //    {
        //        Teacherlist = result.Content.ReadAsAsync<List<addclass>>().Result;
        //    }
        //    return View(Teacherlist);
        //}

        //[HttpPost]
        //public ActionResult AddClass(addclass add)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://www.Edujinni.com/addingclassdetails");
        //        //HTTP POST
        //        var postTask = client.PostAsJsonAsync<addclass>("add", add);
        //        postTask.Wait();
        //        var result = postTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            // return RedirectToAction("Index");
        //            Console.WriteLine("okk");
        //        }
        //        else
        //        {
        //            Console.WriteLine("error");
        //        }
        //    }

        //    ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
        //    return View(add);
        //}


        //public async Task<ActionResult> AddClass(addclass add)
        public async Task<ActionResult> AddClass(addclass add)
        {
            add.gettingdetails();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.edujinni.in/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage response = await client.PostAsJsonAsync("classNames/classDetailsList", add);
            //add.insert_by = "Srikar";
            //add.insert_date = DateTime.Now;
            //add.update_by = "srikar";
            //add.update_date = DateTime.Now;
            if (response.IsSuccessStatusCode == true)
            {
                Response.Cookies.Clear();
                ModelState.Clear();
                return View();
            }

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
