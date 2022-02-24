using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class MeezanBankMonthlyIncomeExpenseReport
    {
        [Key]
        public int Id { get; set; }
        public string InnuzalProjectDesc { get; set; }
        public int? InnuzalProjectBalance { get; set; }
        public string AccessorySaleDesc { get; set; }
        public int? AccessorySaleBalance { get; set; }
        public string StoreMaterialDesc { get; set; }
        public int? StoreMaterialBalance { get; set; }
        public string ScrabSaleDesc { get; set; }
        public int? ScrabSaleBalance { get; set; }
        public string ReparningDesc { get; set; }
        public int? ReparningBalance { get; set; }
        public string DifferentIncomeDesc { get; set; }
        public int? DifferentIncomeBalance { get; set; }
        public string NoTitleDesc { get; set; }
        public int? NoTitleBalance { get; set; }
        public string NoTitle2Desc { get; set; }
        public int? NoTitle2Balance { get; set; }
        public int? TotalIncome { get; set; }
        public int? TotalExpense { get; set; }
        public int? ClosingBalance { get; set; }

        [Display(Name = "تاریخ")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime ValueDate { get; set; }


        [Display(Name = "Account Manager")]
        [Required(ErrorMessage = "Sign is required")]
        public string SignAManager { get; set; }
        [Required(ErrorMessage = "Remarks is required")]
        [Display(Name = "Remarks")]
        public string AManagerRemarks { get; set; }


        [Display(Name = "D.G.M")]
        public string SignDgm { get; set; }
        [Display(Name = "Remarks")]
        public string DgmRemarks { get; set; }


        [Display(Name = "G.M")]
        public string SignGM { get; set; }
        [Display(Name = "Remarks")]
        public string GMRemarks { get; set; }
        public string Status { get; set; }
        public int DelProduction { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        [NotMapped]
        public List<string> Images { get; set; }
    }
}
