using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class DiaryModel
    {
        public string Class { get; set; }
        public string Section { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string ClassRelatedTest { get; set; }
        public string HomeWork { get; set; }
    }
}