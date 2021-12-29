using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MeezanBankIEReportVoucher
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ")]
        [Required]
        public DateTime ValueDate { get; set; }


        [Display(Name = "تفصیل")]
        [Required]
        public string Description { get; set; }


        [Display(Name = "c-No|D-slip|Oline")]
        [Required]
        public string CDO { get; set; }



        [Display(Name = " Debit")]
        [Required]
        public float Debit { get; set; }


        [Display(Name = "Cradit")]
        [Required]
        public float Cradit { get; set; }

        [Display(Name = "Balance")]
        [Required]
        public float Balance { get; set; }

        //sign img for CEO
       public string Imgceo { get; set; }

        //sign img for GM
        public string Imggm { get; set; }

        //sign img for DGM
        public string Imgdgm { get; set; }

        //sign img for Account mananger
        public string Imgam { get; set; }

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
