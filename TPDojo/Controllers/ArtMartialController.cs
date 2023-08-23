using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;
using TPDojo;

namespace TPDojo.Controllers
{
    public class ArtMartialController : Controller
    {
        private readonly DojoDbContext _context;

        public ArtMartialController(DojoDbContext context)
        {
            _context = context;
        }

        // GET: ArtMartials
        public async Task<IActionResult> Index()
        {
              return _context.ArtMartial != null ? 
                          View(await _context.ArtMartial.ToListAsync()) :
                          Problem("Entity set 'DojoDbContext.ArtMartial'  is null.");
        }

        // GET: ArtMartials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ArtMartial == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtMartial
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artMartial == null)
            {
                return NotFound();
            }

            return View(artMartial);
        }

        // GET: ArtMartials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtMartials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ArtMartial artMartial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artMartial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artMartial);
        }

        // GET: ArtMartials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ArtMartial == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtMartial.FindAsync(id);
            if (artMartial == null)
            {
                return NotFound();
            }
            return View(artMartial);
        }

        // POST: ArtMartials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ArtMartial artMartial)
        {
            if (id != artMartial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artMartial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtMartialExists(artMartial.Id))
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
            return View(artMartial);
        }

        // GET: ArtMartials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ArtMartial == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtMartial
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artMartial == null)
            {
                return NotFound();
            }

            return View(artMartial);
        }

        // POST: ArtMartials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ArtMartial == null)
            {
                return Problem("Entity set 'DojoDbContext.ArtMartial'  is null.");
            }
            var artMartial = await _context.ArtMartial.FindAsync(id);
            if (artMartial != null)
            {
                _context.ArtMartial.Remove(artMartial);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtMartialExists(int id)
        {
          return (_context.ArtMartial?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
