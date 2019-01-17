using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class Addteacher
    {
        public int teacher_id { get; set; }
        public string teacher_image { get; set; }
        [Required]
        [StringLength(25)]
        public string teacher_first_name { get; set; }
        [Required]
        [StringLength(25)]
        public string teacher_last_name { get; set; }
        [Required]
        [StringLength(25)]
        public string teacher_email { get; set; }
        [Required]
        [MaxLength(6)]
        public string teacher_teacherid { get; set; }
        [Required]
        [MaxLength(10)]
        public string teacher_phone_no { get; set; }
        public DateTime teacher_dob { get; set; }
        [Required]
        [StringLength(10)]
        public string teacher_gender { get; set; }
        [Required]
        [StringLength(15)]
        public string teacher_subject1 { get; set; }
        public string teacher_subject2 { get; set; }
        [Required]
        [StringLength(25)]
        public string teacher_qualification { get; set; }
        [Required]
        [StringLength(25)]
        public string teacher_department { get; set; }
        public string teacher_flat_no { get; set; }
        public string teacher_buildingname { get; set; }
        public string teacher_street { get; set; }
        public string teacher_street1 { get; set; }
        public string teacher_area { get; set; }
        [Required]
        [StringLength(25)]
        public string teacher_city { get; set; }
        [Required]
        [StringLength(25)]
        public string teacher_state { get; set; }
        [Required]
        [MaxLength(6)]
        public string teacher_pincode { get; set; }
        [Required]
        public DateTime teacher_date_of_joining { get; set; }
        public string Password { get; set; }
        public string Confirm_password { get; set; }
        public string insert_by { get; set; }
        public DateTime insert_date { get; set; }
        public string update_by { get; set; }
        public DateTime update_date { get; set; }
        public int class_id { get; set; }
        public int school_id { get; set; }


    }
}