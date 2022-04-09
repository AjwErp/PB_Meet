using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MonthlyIncomeExpenceInternalAccountReport
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string SelectedDate { get; set; }

        public string IncomeBalance1 { get; set; }
        public string IncomeDescription1 { get; set; }
        public string IncomeBalance2 { get; set; }
        public string IncomeDescription2 { get; set; }
        public string IncomeBalance3 { get; set; }
        public string IncomeDescription3 { get; set; }
        public string ExpenceBalance { get; set; }
        public string ExpenceDescription { get; set; }

        public string TotalIncomeBalance { get; set; }
        public string TotalExpenceBalance { get; set; }
        public string ClosingBalance { get; set; }

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
