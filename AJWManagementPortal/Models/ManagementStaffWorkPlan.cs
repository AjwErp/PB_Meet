using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class ManagementStaffWorkPlan
    {
        //This Model refeer to Management Staff Work Plan (Production Office)---- 

        [Key]
        public int Id { get; set; }

        [Display(Name = "Date")]
        public string MPDate { get; set; }


        [Display(Name = "Name")]
        public string MPName { get; set; }


        [Display(Name = "Designation")]
        public string MPDesignation { get; set; }


        [Display(Name = "Time In")]
        public string Timein { get; set; }


        [Display(Name = "Time Out")]
        public string Timeout { get; set; }


        [Display(Name = "Description")]
        public string MPDescription { get; set; }

        [Display(Name = "Sign Officer")]
        public string Signofficer { get; set; }


        [Display(Name = "Production Manager")]
        public string SignPManagerMP { get; set; }

        [Display(Name = "Remarks")]
        public string PManagerRemarksMP { get; set; }


        [Display(Name = "G.M")] 
        public string SignGMMP { get; set; }

        [Display(Name = "Remarks")]
        public string GMRemarksMP { get; set; }


        [Display(Name = "C.E.O")] 
        public string SignCeoMP { get; set; }

        [Display(Name = "Remarks")]
        public string CeoRemarksMP { get; set; }


        public string MPStatus { get; set; }
        public string MPTitle { get; set; }

        public int DelProductionMP { get; set; }

        public int DelGmMP { get; set; }

        public int DelCeoMP { get; set; }

        public int DelRepoMP { get; set; }
    }
}
