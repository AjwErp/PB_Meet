using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    //This Model Refer to Daily Plan IN/Out (Production Office )but we will replace by 
     //Technical/Management Staff Work Plan --
    public class DailyPlanInOutModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        //[Display(Name = "")]
        public string Designation { get; set; }

        [Required]
        [Display(Name = "Time In")]
        public DateTime DateTimeIn { get; set; }

        [Required]
        [Display(Name = "Time Out")]
        public DateTime DateTimeOut { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Sign { get; set; }
    }
}
