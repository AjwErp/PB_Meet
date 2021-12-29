using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class SubLedger
    {  
        //This Model refeer to SubLedger in (Account Offcie)--- 

        [Key]
        public int Id { get; set; }

        [Display(Name = "SubLedger Name")]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Ledger")]
        public int LedgerId { get; set; }

        [ForeignKey("LedgerId")]
        public virtual Ledger Ledger { get; set; }
    }
}
