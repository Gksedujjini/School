using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class Addteacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Int64 PhoneNo { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public string TeacherID { get; set; }
        public string WorkType { get; set; }
        public string FlatNO { get; set; }
        public string Street { get; set; }
        public string AreaCityState { get; set; }
        public Int32 PinCode { get; set; }
        public DateTime DateOfJoining { get; set; }

    }
}