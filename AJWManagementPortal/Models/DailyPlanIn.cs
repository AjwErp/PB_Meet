using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class DailyPlanIn
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        //[Display(Name = "")]
        public string Designation { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string sign { get; set; }

    }
}
