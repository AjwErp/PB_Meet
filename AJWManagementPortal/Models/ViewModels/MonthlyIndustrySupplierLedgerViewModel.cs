using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models.ViewModels
{
    public class MonthlyIndustrySupplierLedgerViewModel
    {
        public int DailyCashId { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Devit { get; set; }
        public int? PreOrderCheckNo { get; set; }
        public string LedgerType { get; set; }
        public string Description { get; set; }
        public DateTime DailyCashDate { get; set; }
    }
}
