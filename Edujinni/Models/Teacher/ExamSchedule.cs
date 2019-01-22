using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models.Teacher
{
    public class ExamSchedule
    {
        public string Class { get; set; }
        public string Section { get; set; }
        public string SubjectName { get; set; }
        public string SubjectType { get; set; }
        public Int32 Marks { get; set; }
        public DateTime Date { get; set; }
        public string Unit { get; set; }
        public string SubUnit { get; set; }
        public string Topics { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}