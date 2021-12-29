using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class TechnicalStaffWorkPlan
    {   //This Model refer to AJW Technical Staff work Plan (Production Office)------

        [Key]
        public int Id { get; set; }

        public string Date { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }

        public string Description { get; set; }

        [Display(Name = "Job Card")]
        public float JobCard { get; set; }

        //[Unique(ErrorMessage = "This already exist !!")]
        //[Index("ProjectNumber_Index", IsUnique = true)]
        public string  Remarks { get; set; }


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
