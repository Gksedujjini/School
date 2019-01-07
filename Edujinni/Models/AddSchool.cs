using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class AddSchool
    {
        public int school_id { get; set; }
        public string school_name { get; set; }
        public string school_flat_no { get; set; }
        public string school_street { get; set; }
        public string school_area { get; set; }
        public string school_city { get; set; }
        public string school_state { get; set; }
        public int school_pincode { get; set; }
        public long school_phone_no { get; set; }
        public string school_reg_no { get; set; }
        public byte[] school_image { get; set; }
        public string insert_by { get; set; }
        public System.DateTime insert_date { get; set; }
        public string update_by { get; set; }
        public System.DateTime update_date { get; set; }
    }
}