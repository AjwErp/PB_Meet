using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class DailyPlanOutAccounts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string NameAccount { get; set; }

        [Required]
        [Display(Name = "Designation")]
        public string DesignationAccount { get; set; }

        [Required]
        [Display(Name = "DateTime")]
        public DateTime DateTimeoutAccount { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string DescriptionoutAccount { get; set; }

        [Required]
        [Display(Name = "Sign")]
        public string signAccount { get; set; }

    }
}
