﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Edujinni.Models
{
    public class addstudent
    {
        public int student_id { get; set; }
        public byte[] student_image { get; set; }
        public string student_section { get; set; }
        public string student_first_name { get; set; }
        public string student_last_name { get; set; }
        public string student_roll_no { get; set; }
        public int student_chiled_no { get; set; }
        public DateTime student_dob { get; set; }
        public string student_gender { get; set; }
        public string student_father_name { get; set; }
        public string student_father_mobile_no { get; set; }
        public string student_father_occupation { get; set; }
        public string student_mother_name { get; set; }
        public string student_mother_mobile_no { get; set; }
        public string student_mother_occupation { get; set; }
        public int student_no_of_siblings { get; set; }
        public string student_flat_no { get; set; }
        public string student_buliding_name { get; set; }
        public string student_street { get; set; }
        public string student_street1 { get; set; }
        public string student_area { get; set; }
        public string student_city { get; set; }
        public string student_state { get; set; }
        public int student_pincode { get; set; }
        public string insert_by { get; set; }
        public DateTime insert_date { get; set; }
        public string update_by { get; set; }
        public DateTime update_date { get; set; }
        public DateTime student_admission_date { get; set; }
        public int school_id { get; set; }
        public string Student_status { get; set; }
        public string student_class { get; set; }

        public void GETCLASS()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.edujinni.in/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();
          //  ViewBag.classdetails = "";
           // HttpResponseMessage response = await client.GetAsync("classNames/classDetailsList");
        }
    }
    
}