using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AJWManagementPortal.Models
{
    public class aDailyCash
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "اکاؤنٹ اقسام")]
        [Required]
        public string Name { get; set; }



        [Display(Name = "تفصیل")]
        [Required]
        public string Description { get; set; }


        [Display(Name = "تاریخ")]
        [Required]
        public DateTime ValueDate { get; set; }

        [Display(Name = " رقم ادا")]
        [Required]
        public float paidAmount { get; set; }


        [Display(Name = "کلیریڈ رقم")]
        [Required]
        public float clearedAmount { get; set; }

        [Display(Name = "  انکلیریڈ رقم")]
        [Required]
        public float lnClearedAmount { get; set; }

        [Display(Name = "بقایا رقم")]
        [Required]
        public float remainingGained { get; set; }

        [Display(Name = "سرپلس")]
        public float surplus { get; set; }

        [Display(Name = "پرچيسز ر")]
        public string purchaser { get; set; }

        [Display(Name = "آمدن")]
        [Required]
        public float income { get; set; }

        [Display(Name = "آن لائن")]
        [Required]
        public float pOrder { get; set; }

        [Display(Name = "پرچيز آرڈر")]
        public float online { get; set; }

        [Display(Name = "اکاؤنٹنٹ")]
        [Required]
        public float accountant { get; set; }
        //[Unique(ErrorMessage = "This already exist !!")]
        //[Index("ProjectNumber_Index", IsUnique = true)]
        public string Remarks { get; set; }
        [Display(Name = "Production Manager")]
        public string SignPManager { get; set; }

        [Display(Name = "Remarks")]
        public string PManagerRemarks { get; set; }


        [Display(Name = "G.M")]

        public string SignGM { get; set; }

        [Display(Name = "Remarks")]

        public string GMRemarks { get; set; }

        [Display(Name = "C.E.O")]

        public string SignCeo { get; set; }

        [Display(Name = "Remarks")]

        public string CeoRemarks { get; set; }

        public string Status { get; set; }
        public string Title { get; set; }

        public int DelProduction { get; set; }

        public int DelGm { get; set; }

        public int DelCeo { get; set; }

        public int DelRepo { get; set; }


        //for ledger type variable
        public string LedgerType { get; set; }

    }
}
