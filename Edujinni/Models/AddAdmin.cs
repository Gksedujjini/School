using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class AddAdmin
    {
        public int admin_id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string mobile_no { get; set; }
        public string gender { get; set; }
        public DateTime dateof_birth { get; set; }
        public string password { get; set; }
        public string flat_no { get; set; }
        public string street1 { get; set; }
        public string area { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int pincode { get; set; }
        public string insert_by { get; set; }
        public DateTime insert_date { get; set; }
        public string update_by { get; set; }
        public DateTime update_date { get; set; }
        public byte[] admin_image { get; set; }
        public int school_id { get; set; }

        public AddSchool school_details { get; set; }
    }
}