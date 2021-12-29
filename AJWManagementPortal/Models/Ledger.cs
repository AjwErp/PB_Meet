using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{  
    //This Model refeer to Ledger Table (Account Office)-----
    public class Ledger
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Ledger Name")]
        [Required]
        public string LedgerName { get; set; }
    }
}
