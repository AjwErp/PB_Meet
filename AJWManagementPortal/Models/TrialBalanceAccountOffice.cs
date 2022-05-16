using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class TrialBalanceAccountOffice
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int? KeyValue { get; set; }
        
        public string SelectedDate { get; set; }

        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string Page { get; set; }
        public string Description { get; set; }
        public string AMSignature { get; set; }
        public string AMRemark { get; set; }
        public string DGMSignature { get; set; }
        public string DGMRemark { get; set; }
        public string GMSignature { get; set; }
        public string GMRemark { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
