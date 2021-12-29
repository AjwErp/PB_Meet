using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{

    //this model = eDailyCashes in MTJ_Product project
    public class AccountDailyContinueSheetM
    {
        //--DCS:Daily Continue Sheet
        [Key]
        public int DCSId { get; set; }
        //this date is for sheet date not for entry date
            //DC:Daily Continue Sheet DateTime
            [Display(Name = "DateTime")]
            [Required]
        public DateTime DSDate { get; set; }

        [Display(Name = "Account Type")]
        [Required]
        public string DCSAccountType { get; set; }



        [Display(Name = "Description")]
        [Required]
        public string DCSDescription { get; set; }

        //this date is for entry date
            [Display(Name = "Date")]
            [Required]
        public DateTime DCSDate { get; set; }

        [Display(Name = " Ammount Pay")]
        [Required]
        public float DCSPaidAmount { get; set; }


        [Display(Name = "Cleared Ammount")]
        [Required]
        public float DCSClearedAmount { get; set; }

        [Display(Name = "  Un-Cleared Ammount")]
        [Required]
        public float DCSUnClearedAmount { get; set; }

        [Display(Name = "Remaning Gain Ammount")]
        [Required]
        public float DCSRemainingGaineAmmount { get; set; }

        [Display(Name = "Income")]
        [Required]
        public float DCSIncome { get; set; }

        [Display(Name = "P-Order|G-Pass|S-Order|C-Checq no|D-Slip|O-Online")]
        [Required]
        public float DCSPGSCDO { get; set; }

        [Display(Name = "Opening Balance")]
        [Required]
        public float DCSOpeningBalance { get; set; }

        //Image for Related User Signature
        //[Display(Name = "Account Manager")]
        //[Required]
        //public string DCSImageAccountManager { get; set; }

        //[Display(Name = "C.E.O")]
        //[Required]
        //public string DCSImageCeo { get; set; }

        //[Display(Name = "G.M")]
        //[Required]
        //public string DCSImageGm { get; set; }

        //[Display(Name = "D.G.M")]
        //[Required]
        //public string DCSImageDgm { get; set; }

    }
}
