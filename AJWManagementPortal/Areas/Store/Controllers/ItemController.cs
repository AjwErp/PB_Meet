using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using AJWManagementPortal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Store.Controllers
{ [Area("Store")]
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get INDEX
        public async Task<IActionResult> Index()
        {
            var Items = await _db.Items.Include(s => s.Category).ToListAsync();
            return View(Items);
        }

        //GET - CREATE
        public async Task<IActionResult> Create()
        {
            ItemAndCategoryViewModel model = new ItemAndCategoryViewModel()
            {
                CategoryList = await _db.Categories.ToListAsync(),
                Item = new Models.Item(),
                ItemList = await _db.Items.OrderBy(p => p.ItemName).Select(p => p.ItemName).Distinct().ToListAsync()
            };

            return View(model);
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ItemAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesItemExists = _db.Items.Include(s => s.Category).Where(s => s.ItemName == model.Item.ItemName && s.Category.Id == model.Item.CategoryId);

                if (doesItemExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error : Item exists under " + doesItemExists.First().Category.CategoryName + " Category. Please use another name.";
                }
                else
                {
                    _db.Items.Add(model.Item);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ItemAndCategoryViewModel modelVM = new ItemAndCategoryViewModel()
            {
                CategoryList = await _db.Categories.ToListAsync(),
                Item = model.Item,
                ItemList = await _db.Items.OrderBy(p => p.ItemName).Select(p => p.ItemName).ToListAsync(),
                StatusMessage = StatusMessage
            };
            return View(modelVM);
        }


        [ActionName("GetItem")]
        public async Task<IActionResult> GetItem(int id)
        {
            List<Item> items = new List<Item>();

            items = await (from item in _db.Items
                                  where item.CategoryId == id
                                  select item).ToListAsync();

            return Json(new SelectList(items, "CategoryId", "ItemName"));

        }


        //GET - EDIT action subledger form
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _db.Items.SingleOrDefaultAsync(m => m.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            ItemAndCategoryViewModel model = new ItemAndCategoryViewModel()
            {
                CategoryList = await _db.Categories.ToListAsync(),
                Item = item,
                ItemList = await _db.Items.OrderBy(p => p.ItemName).Select(p => p.ItemName).Distinct().ToListAsync()
            };

            return View(model);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ItemAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesItemExists = _db.Items.Include(s => s.Category).Where(s => s.ItemName == model.Item.ItemName && s.Category.Id == model.Item.CategoryId);

                if (doesItemExists.Count() > 0)
                {
                    //Error
                    StatusMessage = "Error : Item exists under " + doesItemExists.First().Category.CategoryName + " Category. Please use another name.";
                }
                else
                {
                    var subCatFromDb = await _db.Items.FindAsync(model.Item.CategoryId);
                    subCatFromDb.ItemName = model.Item.ItemName;

                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ItemAndCategoryViewModel modelVM = new ItemAndCategoryViewModel()
            {
                CategoryList = await _db.Categories.ToListAsync(),
                Item = model.Item,
                ItemList = await _db.Items.OrderBy(p => p.ItemName).Select(p => p.ItemName).ToListAsync(),
                StatusMessage = StatusMessage
            };
            //modelVM.SubCategory.Id = id;
            return View(modelVM);
        }

        //GET Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var item = await _db.Items.Include(s => s.Category).SingleOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        //GET Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var item = await _db.Items.Include(s => s.Category).SingleOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _db.Items.SingleOrDefaultAsync(m => m.Id == id);
            _db.Items.Remove(item);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
