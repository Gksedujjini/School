using Edujinni.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Sginup()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Sginup(Adminsignup admin)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52995/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();

            HttpResponseMessage response = await client.PostAsJsonAsync("guestSignUp", admin);

            if (response.IsSuccessStatusCode == true)
            {
                Response.Cookies.Clear();
                ModelState.Clear();
                return View();
            }
            return View(admin);
        }
        //public ActionResult Login()
        //{
        //    return View();
        //}
        [HttpPost]
        public async Task<ActionResult> Login(string Name,string password)
        {
            Adminsignup A = new Adminsignup();
            AddAdmin admin = new AddAdmin();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52995/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();
            //HttpResponseMessage response, response1;
            //if (Name ==A.first_name ||password == A.confirm_pswd)
            //{
            //     response = await client.PostAsJsonAsync("guestLogin", A);
            //    if (response.IsSuccessStatusCode == true)
            //    {
            //        Response.Cookies.Clear();
            //        ModelState.Clear();
            //        // return View("_Layout.cshtml");
            //        return View();
            //    }
            //}
            //else
            //{

            //}
            //if (Name == admin.full_name || password == admin.password)
            //{
            //    response1 = await client.PostAsJsonAsync("AdminLogin", A);
            //    if (response1.IsSuccessStatusCode == true)
            //    {
            //        Response.Cookies.Clear();
            //        ModelState.Clear();
            //        //  return View("_Layout.cshtml");
            //        return View();
            //    }
            //}
            HttpResponseMessage response = await client.PostAsJsonAsync("guestLogin", A);
            if (response.IsSuccessStatusCode == true)
            {
                Response.Cookies.Clear();
                ModelState.Clear();
                // return View("_Layout.cshtml");
                return View();
            }
            return View();
        }
    }
}