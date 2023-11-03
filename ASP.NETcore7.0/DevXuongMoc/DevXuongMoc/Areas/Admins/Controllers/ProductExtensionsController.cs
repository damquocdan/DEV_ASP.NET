using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevXuongMoc.Models;

namespace DevXuongMoc.Areas.Admins.Controllers
{
    //[Area("Admins")]
    public class ProductExtensionsController : BaseController
    {
        private readonly DevXuongMocSqlContext _context;

        public ProductExtensionsController(DevXuongMocSqlContext context)
        {
            _context = context;
        }

        // GET: Admins/ProductExtensions
        public async Task<IActionResult> Index()
        {
              return _context.ProductExtensions != null ? 
                          View(await _context.ProductExtensions.ToListAsync()) :
                          Problem("Entity set 'DevXuongMocSqlContext.ProductExtensions'  is null.");
        }

        // GET: Admins/ProductExtensions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductExtensions == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productExtension == null)
            {
                return NotFound();
            }

            return View(productExtension);
        }

        // GET: Admins/ProductExtensions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/ProductExtensions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pid,Eid,Content")] ProductExtension productExtension)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productExtension);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productExtension);
        }

        // GET: Admins/ProductExtensions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductExtensions == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions.FindAsync(id);
            if (productExtension == null)
            {
                return NotFound();
            }
            return View(productExtension);
        }

        // POST: Admins/ProductExtensions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pid,Eid,Content")] ProductExtension productExtension)
        {
            if (id != productExtension.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productExtension);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExtensionExists(productExtension.Id))
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
            return View(productExtension);
        }

        // GET: Admins/ProductExtensions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductExtensions == null)
            {
                return NotFound();
            }

            var productExtension = await _context.ProductExtensions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productExtension == null)
            {
                return NotFound();
            }

            return View(productExtension);
        }

        // POST: Admins/ProductExtensions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductExtensions == null)
            {
                return Problem("Entity set 'DevXuongMocSqlContext.ProductExtensions'  is null.");
            }
            var productExtension = await _context.ProductExtensions.FindAsync(id);
            if (productExtension != null)
            {
                _context.ProductExtensions.Remove(productExtension);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExtensionExists(int id)
        {
          return (_context.ProductExtensions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
