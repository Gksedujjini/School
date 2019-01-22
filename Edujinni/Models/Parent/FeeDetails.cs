using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edujinni.Models.Parent
{
    public class FeeDetails
    {
        public Int64 PaidAmount { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Classs { get; set; }
        public string Section { get; set; }
        public Int64 DueAmount { get; set; }
        public Int64 TotalAcademicFee { get; set; }
        public Int64 TotalDiscount { get; set; }
        public Int64 TotalAmountToBePaid { get; set; }

    }
}