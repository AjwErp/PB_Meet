using AJWManagementPortal.Data;
using AJWManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AJWManagementPortal.Models;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Areas.Sheets.Controllers
{
    [Area("Sheets")]
    public class UserTableController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserTableController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserTable
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserTable.ToListAsync());
        }

        // GET: UserTable/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.UserTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // GET: UserTable/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserTable/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userModel);
        }

        // GET: UserTable/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.UserTable.FindAsync(id);
            if (userModel == null)
            {
                return NotFound();
            }
            return View(userModel);
        }

        // POST: UserTable/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] UserModel userModel)
        {
            if (id != userModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserTableModelExists(userModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userModel);
        }

        // GET: UserTable/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.UserTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // POST: UserTable/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userModel = await _context.UserTable.FindAsync(id);
            _context.UserTable.Remove(userModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserTableModelExists(int id)
        {
            return _context.UserTable.Any(e => e.Id == id);
        }
    }
}
