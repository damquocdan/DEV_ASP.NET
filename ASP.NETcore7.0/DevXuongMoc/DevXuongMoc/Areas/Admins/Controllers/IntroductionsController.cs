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
    [Area("Admins")]
    public class IntroductionsController : Controller
    {
        private readonly DevXuongMocSqlContext _context;

        public IntroductionsController(DevXuongMocSqlContext context)
        {
            _context = context;
        }

        // GET: Admins/Introductions
        public async Task<IActionResult> Index()
        {
              return _context.Introductions != null ? 
                          View(await _context.Introductions.ToListAsync()) :
                          Problem("Entity set 'DevXuongMocSqlContext.Introductions'  is null.");
        }

        // GET: Admins/Introductions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Introductions == null)
            {
                return NotFound();
            }

            var introduction = await _context.Introductions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (introduction == null)
            {
                return NotFound();
            }

            return View(introduction);
        }

        // GET: Admins/Introductions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Introductions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Image,Orders,Description,Home,Type,Parentid,MetaTitle,MetaKeyword,MetaDescription,Slug,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Content,Status,Isdelete")] Introduction introduction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(introduction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(introduction);
        }

        // GET: Admins/Introductions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Introductions == null)
            {
                return NotFound();
            }

            var introduction = await _context.Introductions.FindAsync(id);
            if (introduction == null)
            {
                return NotFound();
            }
            return View(introduction);
        }

        // POST: Admins/Introductions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Image,Orders,Description,Home,Type,Parentid,MetaTitle,MetaKeyword,MetaDescription,Slug,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Content,Status,Isdelete")] Introduction introduction)
        {
            if (id != introduction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(introduction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IntroductionExists(introduction.Id))
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
            return View(introduction);
        }

        // GET: Admins/Introductions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Introductions == null)
            {
                return NotFound();
            }

            var introduction = await _context.Introductions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (introduction == null)
            {
                return NotFound();
            }

            return View(introduction);
        }

        // POST: Admins/Introductions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Introductions == null)
            {
                return Problem("Entity set 'DevXuongMocSqlContext.Introductions'  is null.");
            }
            var introduction = await _context.Introductions.FindAsync(id);
            if (introduction != null)
            {
                _context.Introductions.Remove(introduction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IntroductionExists(int id)
        {
          return (_context.Introductions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
