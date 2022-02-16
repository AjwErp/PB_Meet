using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Models.ViewModels
{
    public class ItemAndCategoryViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public Item Item { get; set; }
        public List<string> ItemList { get; set; }
        public string StatusMessage { get; set; }
    }
}
