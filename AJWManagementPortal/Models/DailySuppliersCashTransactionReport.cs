using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace AJWManagementPortal.Models
{
    public class DailySuppliersCashTransactionReport
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ")]
        public DateTime ValueDate { get; set; }


        [Display(Name = "تفصیل")]
        public string Description { get; set; }


        [Display(Name = " Debit")]
        public float Debit { get; set; }


        [Display(Name = "Cradit")]
        public float Cradit { get; set; }

        [Display(Name = "Balance")]
        public float Balance { get; set; }
        public float bCradit { get; set; }
        public float bDebit { get; set; }
        public float bBalance { get; set; }

        public string Remarks { get; set; }
        [Display(Name = "Production Manager")]
        public string SignPManager { get; set; }

        [Display(Name = "Remarks")]
        public string PManagerRemarks { get; set; }


        [Display(Name = "G.M")]

        public string SignGM { get; set; }

        [Display(Name = "Remarks")]

        public string GMRemarks { get; set; }

        [Display(Name = "C.E.O")]

        public string SignCeo { get; set; }

        [Display(Name = "Remarks")]

        public string CeoRemarks { get; set; }

        public string Status { get; set; }
        public string Title { get; set; }

        public int DelProduction { get; set; }

        public int DelGm { get; set; }

        public int DelCeo { get; set; }

        public int DelRepo { get; set; }
    }
}
