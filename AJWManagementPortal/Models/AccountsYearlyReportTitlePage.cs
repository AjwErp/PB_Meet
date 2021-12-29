using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class AccountsYearlyReportTitlePage
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required]
        public string YRDate { get; set; }

        //Its all variables related to the Signature & Status for sending and receiving file
        //  YR = Yearly Report

        [Display(Name = "Accounts Manager")]
        [Required]
        public string SignAManagerYR { get; set; }

        [Display(Name = "Remarks")]
        [Required]
        public string AManagerRemarksYR { get; set; }

        [Display(Name = "D.G.M")]
        public string SignDgmYR { get; set; }

        [Display(Name = "Remarks")]
        public string DgmRemarksYR { get; set; }

        [Display(Name = "G.M")]
        public string SignGMYR { get; set; }

        [Display(Name = "Remarks")]
        public string GMRemarksYR { get; set; }


        public string YRStatus { get; set; }
        public string YRTitle { get; set; }

        public int DelAccountsYR { get; set; }

        public int DelDgmYR { get; set; }

        public int DelGmYR { get; set; }

        public int DelRepoYR { get; set; }


    }
}
