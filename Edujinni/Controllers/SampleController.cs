using Edujinni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddTeacher(Addteacher add)
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddTeacher()
        {
            if (ModelState.IsValid)
            {
                //    HttpClient client = new HttpClient();
                //    var result = client.PostAsJsonAsync("http://www.edujinni.in/addingTeacher").Result;
                //    if(result.IsSuccessStatusCode)
                //    {
                //        //Addt = result.Content.ReadAsAsync<Addteacher>().Result;
                //        ViewBag.Result = "Successfully saved";
                //        return View(new Addteacher());
                //    }

            }
            else
            {
                ViewBag.Result = "Please try with valid data";
            }
            return View();
        }
    }
}