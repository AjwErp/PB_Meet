using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MeezanBankIEVoucher
    {
        [Key]
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public String checkNumber { get; set; }
        public String amount { get; set; }
        public String purpose { get; set; }

        public String description { get; set; }

        public string Remarks { get; set; }
        [Display(Name = "Production Manager")]
        public string SignPManager { get; set; }

        [Display(Name = "Remarks")]
        public string PManagerRemarks { get; set; }
        public string rBalance { get; set; }
        public string incomeTa { get; set; }
        public string checkcash { get; set; }
        public string currentBalance { get; set; }


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
