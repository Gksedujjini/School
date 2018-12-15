using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class TeacherModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public Int64 phone_no { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string subject1 { get; set; }
        public string subject2 { get; set; }
        public string qualification { get; set; }

        public string teacherid { get; set; }
        public string desigination { get; set; }
        public string flat_no { get; set; }
        public string street { get; set; }
        public string area { get; set; }
        public Int32 pincode { get; set; }
        public DateTime dateofjoining { get; set; }
        public string image { get; set; }
    }
}