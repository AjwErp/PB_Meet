using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class DCashClosingSupplierLedger
    {
        public int Id { get; set; }
         public DateTime DateDCCS { get; set; }
        public float Credit { get; set; }
        public float Debit { get; set; }
        public float TotalBillPay { get; set; }
        public float TotalBill { get; set; }
        public float TotalCash { get; set; }

    }
}
