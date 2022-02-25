using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MonthlyMainBankLedgerBook
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int MainBankDailyCashId { get; set; }
        public string SignPManager { get; set; }
        public string PManagerRemarks { get; set; }
        public string SignGM { get; set; }
        public string GMRemarks { get; set; }
        public string SignCeo { get; set; }
        public string CeoRemarks { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Devit { get; set; }
        public string CDO { get; set; }
        public string Description { get; set; }
        public DateTime MainBankDailyCashDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
