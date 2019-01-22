using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models.Parent
{
    public class EditProfile
    {
        public Int64 ParentId { get; set; }
        public Int64 PhoneNo { get; set; }
        public string Gender { get; set; }
        public string FlatNo { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string PinCode { get; set; }
        public string SchoolName { get; set; }
        public string SchoolFlatNo { get; set; }
        public string SchoolStreet1 { get; set; }
        public string SchoolArea { get; set; }
        public string SchoolPinCode { get; set; }
        public string SchoolMobileNo { get; set; }
        public string Password { get; set; }
    }
}