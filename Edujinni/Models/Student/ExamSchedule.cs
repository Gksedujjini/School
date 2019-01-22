using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models.Student
{
    public class ExamSchedule
    {
        public string Classs { get; set; }
        public string Section { get; set; }
        public string ExamType { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }
}