using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models
{
    public class MessageModel
    {
        public string Message { get; set; }
        public string To { get; set; }
        public DateTime Class { get; set; }
        public string Section { get; set; }
    }
}