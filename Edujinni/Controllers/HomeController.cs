using Edujinni.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Sginup()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Sginup(Adminsignup admin)
        {
            //Adminsignup admin = new Adminsignup();
            SqlConnection con = null;
            con = new SqlConnection("Data Source=.;Initial Catalog=sample;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Insert Into REGISTRATION (FIRSTNAME,LASTNAME,PASSWORD) VALUES(@FirstName,@LastName,@Email)",con);
            con.Open();
            cmd.Parameters.AddWithValue("@FirstName",admin.FirstName);
            cmd.Parameters.AddWithValue("@LastName",admin.LastName);
            cmd.Parameters.AddWithValue("@Email",admin.Email);
            cmd.ExecuteNonQuery();
            con.Close();
            return View();
        }
    }
}