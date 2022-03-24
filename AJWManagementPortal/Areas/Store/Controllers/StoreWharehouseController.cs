using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{ [Area("Store")]
    public class StoreWharehouseController : Controller
    {
        //GET : This method used for Store WhareHouse List
        public IActionResult StoreWharehouseList()
        {
            return View();
        }
        //GET : This method used for Store WhareHouse List 
        //POST : This method used for Store WhareHouse List
        //POST : This method used for Store WhareHouse List

        //GET : This method used for Store WhareHouse for Item Category & Item List with Category
        public IActionResult StoreItemCategoryList()
        {
            return View();
        }
        //GET : This method used for Store WhareHouse for Item Category & Item List with Category
        //POST : This method used for Store WhareHouse for Item Category & Item List with Category
        //POST : This method used for Store WhareHouse for Item Category & Item List with Category

        //GET : This method used for Store WhareHouse for Item Category & Item List with Category
        public IActionResult StoreItemList()
        {
            return View();
        }
        //GET : This method used for Store WhareHouse for Item List with Category
        //POST : This method used for Store WhareHouse for Item List with Category
        //POST : This method used for Store WhareHouse for Item List with Category
    }
}
