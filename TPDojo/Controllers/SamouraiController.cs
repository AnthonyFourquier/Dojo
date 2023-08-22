using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;
using TPDojo;
using TPDojo.Models;
using Microsoft.Data.SqlClient;

namespace TPDojo.Controllers
{
    public class SamouraiController : Controller
    {
        private readonly DojoDbContext _context;

        public SamouraiController(DojoDbContext context)
        {
            _context = context;
        }

        // GET: Samourai
        public async Task<IActionResult> Index(String sortOrder, string searchString, int? pageNumber, string currentFilter)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["ForceSortParm"] = String.IsNullOrEmpty(sortOrder) ? "force_desc" : "force";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var result = (from samourai in _context.Samourai select samourai);
            if (!String.IsNullOrEmpty(searchString))
            {
                result = result.Where(s => s.Name.StartsWith(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    result = result.OrderByDescending(s => s.Name);
                    break;
                case "force_desc":
                    result = result.OrderByDescending(s => s.Force);
                    break;
                case "force":
                    result = result.OrderBy(s => s.Force);
                    break;
                default:
                    result = result.OrderBy(s => s.Name);
                    break;
            }

            int pageSize = 7;
            var max = result.Count() / 7;
            ViewData["MaxPage"] = max +1;

            return View(await PaginatedList<Samourai>.CreateAsync(result.Include(s => s.Arme).AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Samourai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Samourai == null)
            {
                return NotFound();
            }

            var samourai = await _context.Samourai.Include(s => s.Arme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (samourai == null)
            {
                return NotFound();
            }

            return View(samourai);
        }

        // GET: Samourai/Create
        public IActionResult Create()
        {
            SamouraiVM samouraiVM = new SamouraiVM()
            {
                Armes = new SelectList(_context.Arme.ToList(), "Id", "Name")
            };

            return View(samouraiVM);
        }

        // POST: Samourai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Force,ArmeId")] Samourai samourai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(samourai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(samourai);
        }

        // GET: Samourai/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Samourai == null)
            {
                return NotFound();
            }

            var samourai = await _context.Samourai.FindAsync(id);
            if (samourai == null)
            {
                return NotFound();
            }
            var armesNoDispo = from s in _context.Samourai
                             join a in _context.Arme on s.ArmeId equals a.Id
                             select a;
           var armesAll = _context.Arme;
           var armesDispo = armesAll.Except(armesNoDispo);
           
            SamouraiVM samouraiVM = new SamouraiVM()
            {
                Id = samourai.Id,
                Name = samourai.Name,
                Force = samourai.Force, 
                Armes = new SelectList(armesDispo, "Id", "Name"),
                ArmeId = samourai.ArmeId
            };

            return View(samouraiVM);
        }

        // POST: Samourai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Force,ArmeId")] Samourai samourai)
        {
            if (id != samourai.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(samourai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SamouraiExists(samourai.Id))
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
            return View(samourai);
        }

        // GET: Samourai/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Samourai == null)
            {
                return NotFound();
            }

            var samourai = await _context.Samourai
                .FirstOrDefaultAsync(m => m.Id == id);
            if (samourai == null)
            {
                return NotFound();
            }

            return View(samourai);
        }

        // POST: Samourai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Samourai == null)
            {
                return Problem("Entity set 'DojoDbContext.Samourai'  is null.");
            }
            var samourai = await _context.Samourai.FindAsync(id);
            if (samourai != null)
            {
                _context.Samourai.Remove(samourai);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SamouraiExists(int id)
        {
            return (_context.Samourai?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
