using Edujinni.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
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
                return View();
            }
            //Adminsignup admin = new Adminsignup();
            //SqlConnection con = null;
            //con = new SqlConnection("Data Source=.;Initial Catalog=sample;Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("Insert Into REGISTRATION (FIRSTNAME,LASTNAME,PASSWORD) VALUES(@FirstName,@LastName,@Email)",con);
            //con.Open();
            //cmd.Parameters.AddWithValue("@FirstName",admin.FirstName);
            //cmd.Parameters.AddWithValue("@LastName",admin.LastName);
            //cmd.Parameters.AddWithValue("@Email",admin.Email);
            //cmd.ExecuteNonQuery();
            //con.Close();
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }
    }
}