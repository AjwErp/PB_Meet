using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    //This Model refer to Notice Board (HRM Office)
    public class AJWNoticeBoardHrm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
