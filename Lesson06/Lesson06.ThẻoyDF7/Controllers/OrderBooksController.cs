using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lesson06.TheoryDF7.Models;

namespace Lesson06.TheoryDF7.Controllers
{
    public class OrderBooksController : Controller
    {
        private readonly BookStoreContext _context;

        public OrderBooksController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: OrderBooks
        public async Task<IActionResult> Index()
        {
            var bookStoreContext = _context.OrderBooks.Include(o => o.Account);
            return View(await bookStoreContext.ToListAsync());
        }

        // GET: OrderBooks/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.OrderBooks == null)
            {
                return NotFound();
            }

            var orderBook = await _context.OrderBooks
                .Include(o => o.Account)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderBook == null)
            {
                return NotFound();
            }

            return View(orderBook);
        }

        // GET: OrderBooks/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId");
            return View();
        }

        // POST: OrderBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,OrderDate,AccountId,ReceiveAddress,ReceivePhone,OrderReceive,Note,Status")] OrderBook orderBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", orderBook.AccountId);
            return View(orderBook);
        }

        // GET: OrderBooks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.OrderBooks == null)
            {
                return NotFound();
            }

            var orderBook = await _context.OrderBooks.FindAsync(id);
            if (orderBook == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", orderBook.AccountId);
            return View(orderBook);
        }

        // POST: OrderBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("OrderId,OrderDate,AccountId,ReceiveAddress,ReceivePhone,OrderReceive,Note,Status")] OrderBook orderBook)
        {
            if (id != orderBook.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderBookExists(orderBook.OrderId))
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
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", orderBook.AccountId);
            return View(orderBook);
        }

        // GET: OrderBooks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.OrderBooks == null)
            {
                return NotFound();
            }

            var orderBook = await _context.OrderBooks
                .Include(o => o.Account)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderBook == null)
            {
                return NotFound();
            }

            return View(orderBook);
        }

        // POST: OrderBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.OrderBooks == null)
            {
                return Problem("Entity set 'BookStoreContext.OrderBooks'  is null.");
            }
            var orderBook = await _context.OrderBooks.FindAsync(id);
            if (orderBook != null)
            {
                _context.OrderBooks.Remove(orderBook);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderBookExists(string id)
        {
          return (_context.OrderBooks?.Any(e => e.OrderId == id)).GetValueOrDefault();
        }
    }
}
