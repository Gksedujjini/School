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
        //private CatContext _Context;
       
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
        public ActionResult AddStudent()
        {
            return View();
        }

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
            addclass a = new addclass();
            a.gettingdetails();
            //student.GETCLASS();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.edujinni.in/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();
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
        public ActionResult EditStudentOverView()
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
      
        //RESULTS SCREENS GOES HERE
        public ActionResult AddResultView()
        {
            return View();
        }
        public ActionResult Viewresult()
        {
            return View();
        }
        public ActionResult StudentResult()
        {
            return View();
        }
        public ActionResult AddMarks()
        {
            return View();
        }

        //LEADING BOARD SCREENS
        public ActionResult AddLeadingBoard()
        {
            return View();
        }
        public ActionResult LeadingBoardView()
        {
            return View();
        }

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

        //public ActionResult AddClass()
        //{
        //    return View();
        //}
        public async Task<ActionResult> addclass(addclass add)
        {
            addclass addd = new addclass();
            //add.gettingdetails();
            //add.addingdetails();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.edujinni.in/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // List all Names.
            HttpResponseMessage response = client.GetAsync("classNames/classDetailsList").Result;  // Blocking call!  
            string cname = response.Content.ReadAsStringAsync().Result;
            var pname = response.RequestMessage.ToString().ToList();
            var tname = response.Headers.ToList();
            string kname = response.IsSuccessStatusCode.ToString();
            string lname = response.ReasonPhrase.ToString();

            string fname = response.StatusCode.ToString();
            string mname = Response.StatusCode.ToString();

            string rname = response.Version.ToString();
            string gname = Response.Output.ToString();
            string cfname = Response.Status.ToString();
            string llname = Response.Buffer.ToString();
            string kkname = Response.BufferOutput.ToString();
            string laname = Response.OutputStream.ToString();
          
           // string nn = response.TryGetContentValue(out cname).ToString();

            if (response.IsSuccessStatusCode)
            {
                //string s = nn;
                SelectList list = new SelectList(lname,"class_name");
                //string s = list;             
                ViewBag.class_name = list;             
            }
            else
            {
                //Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
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

        //EXAM SCHEDULES
        public ActionResult ExamSchedules()
        {
            return View();
        }
        public ActionResult AddExam()
        {
            return View();
        }
        //MESSAGE
        public ActionResult Message()
        {
            return View();
        }
        //FEE COLLECTION
        public ActionResult FeeCollection()
        {
            return View();
        }
        //REQUESTED PAGE
        public ActionResult RequestedPage()
        {
            return View();
        }
       
    }
}
