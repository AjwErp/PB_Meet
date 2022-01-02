using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MonthlyClosingReport
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime ValueDate { get; set; }


        [Display(Name = "Account Manager")]
        [Required(ErrorMessage = "Sign is required")]
        public string SignAManager { get; set; }
        [Required(ErrorMessage = "Remarks is required")]
        [Display(Name = "Remarks")]
        public string AManagerRemarks { get; set; }


        [Display(Name = "D.G.M")]
        public string SignDgm { get; set; }
        [Display(Name = "Remarks")]
        public string DgmRemarks { get; set; }


        [Display(Name = "G.M")]
        public string SignGM { get; set; }
        [Display(Name = "Remarks")]
        public string GMRemarks { get; set; }
        public string Status { get; set; }
        public int DelProduction { get; set; }
        public int Month { get; set; }
        public int Year{ get; set; }

    }
}
