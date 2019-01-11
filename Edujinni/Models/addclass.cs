using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Edujinni.Models
{
    public class addclass
    {
        //public string classTeacher { get; set; }
        //public string ClassName { get; set; }
        //public string SectionName { get; set; }

        public string class_name { get; set; }
        public string class_section_name { get; set; }
        //public string teacher_id { get; set; }
        //public IEnumerable<String> teacher_id { get; set; }
        public List<SelectListItem> teacher_id { get; set; }
        public string insert_by { get; set; }
        public DateTime insert_date { get; set; }
        public string update_by { get; set; }
        public DateTime update_date { get; set; }
        public string balance { get; set; }

        List<SelectListItem> list = new List<SelectListItem>();
        //FOR GETTING THE DETAILS
        public  void  gettingdetails()
         {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.edujinni.in/");
            // Add an Accept header for JSON format.    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // List all Names.    
            HttpResponseMessage response = client.GetAsync("classNames/classDetailsList").Result;  // Blocking call!    
            if (response.IsSuccessStatusCode)
            {
                var classTeacher = response.Content.ReadAsStringAsync().Result;
                balance = class_name;
               // balance.ToList();

            }
            else
            {
                //Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    //FOR POSTING THE DETAILS
    //public class addingdetails
    //{
    //    static void Main(string[] args)
    //    {
    //        using (var client = new HttpClient())
    //        {
    //            addclass p = new addclass { ClassName = "5th class", SectionName = "dazzle" };
    //            client.BaseAddress = new Uri("http://www.edujinni.in/");
    //            var response = client.PostAsJsonAsync("addingclassdetails", p).Result;
    //            if (response.IsSuccessStatusCode)
    //            {
    //                Console.Write("Success");
    //            }
    //            else
    //                Console.Write("Error");
    //        }
    //    }
}
}