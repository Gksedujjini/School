using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class Adminsignup
    {
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25)]
        public string LastName { get; set; }
        // public Int64 MobileNumber { get; set; }
        [Required]
        [MaxLength(10)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public string DOB { get; set; }
        [Required]
        [StringLength(8)]
        public string createPassword { get; set; }
        [Required]
        [StringLength(8)]
        public string confirm_pswd { get; set; }
        [Required]
        [StringLength(8)]
        public string Gender { get; set; }
        public string insert_by { get; set; }
        public DateTime insert_date { get; set; }
        public string update_by { get; set; }
        public DateTime update_date { get; set; }



    }
}