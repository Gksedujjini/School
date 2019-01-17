using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class AssignmentModel
    {
        public string Class { get; set; }
        public string Section { get; set; }
        public string Topic { get; set; }
        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }
        public string Subject { get; set; }
        public string AssignmentText { get; set; }
    }
}