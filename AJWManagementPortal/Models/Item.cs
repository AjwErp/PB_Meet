using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models
{
    public class Item
    {
        //This Model refer to Item of Category in (Store Offcie)--- 

        [Key]
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required]
        public string Date { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        public string CategoryName { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Required]
        [Display(Name = "Size")]
        public string ItemSize { get; set; }

        [Required]
        [Display(Name = "Arrival Weight")]
        public string ArrivalWeight { get; set; }

        [Required]
        [Display(Name = "Arrival Quantity")]
        public string ArrivalQuantity { get; set; }

        [Required]
        [Display(Name = "Arrival Price")]
        public string ArrivalPrice { get; set; }

        [Required]
        [Display(Name = "Per Unit Price")]
        public string PerUnitPrice { get; set; }

        [Required]
        [Display(Name = "Total Price")]
        public string TotalPrice { get; set; }

        [Required]
        [Display(Name = "Total Unit")]
        public string TotalUnit { get; set; }

        [Required]
        [Display(Name = "Remain Unit")]
        public string RemainUnit { get; set; }

        [Required]
        [Display(Name = "Total Weight")]
        public string TotalWeight { get; set; }

        [Required]
        [Display(Name = "Remain Weight")]
        public string RemainWeight { get; set; }

        [Required]
        [Display(Name = "Officer Name")]
        public string OfficerName { get; set; }

        [Required]
        [Display(Name = "Material voucher No")]
        public string MaterialvoucherNo { get; set; }

        [Required]
        [Display(Name = "Purchase Order No")]
        public string PurchaseOrderNo { get; set; }

        [Required]
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }


        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
