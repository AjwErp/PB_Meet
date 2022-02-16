using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MeezanBankMonthlyIncomeExpenseReportImage
    {
        [Key]
        public int Id { get; set; }
        public int MeezanBankMonthlyIncomeExpenseReportId { get; set; }
        public string Filepath { get; set; }
    }
}
