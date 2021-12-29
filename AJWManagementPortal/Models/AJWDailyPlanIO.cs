using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class AJWDailyPlanIO
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
        public string Signature { get; set; }
    }
}
