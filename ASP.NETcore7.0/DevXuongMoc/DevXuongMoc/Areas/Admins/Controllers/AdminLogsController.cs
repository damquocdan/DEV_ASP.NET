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
    public class AdminLogsController : BaseController
    {
        private readonly DevXuongMocSqlContext _context;

        public AdminLogsController(DevXuongMocSqlContext context)
        {
            _context = context;
        }

        // GET: Admins/AdminLogs
        public async Task<IActionResult> Index()
        {
              return _context.AdminLogs != null ? 
                          View(await _context.AdminLogs.ToListAsync()) :
                          Problem("Entity set 'DevXuongMocSqlContext.AdminLogs'  is null.");
        }

        // GET: Admins/AdminLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdminLogs == null)
            {
                return NotFound();
            }

            var adminLog = await _context.AdminLogs
                .FirstOrDefaultAsync(m => m.LogId == id);
            if (adminLog == null)
            {
                return NotFound();
            }

            return View(adminLog);
        }

        // GET: Admins/AdminLogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/AdminLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LogId,Status,SessionId,AppCode,ThreadId,StartTime,EndTime,AdminUserId,UserLogin,UserName,IpAddress,ActionCode,ActionName,MenuCode,MenuName,WebpagesActionId,ActionType,ObjectId,Content,Description,LogLevel,ErrorCode")] AdminLog adminLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminLog);
        }

        // GET: Admins/AdminLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdminLogs == null)
            {
                return NotFound();
            }

            var adminLog = await _context.AdminLogs.FindAsync(id);
            if (adminLog == null)
            {
                return NotFound();
            }
            return View(adminLog);
        }

        // POST: Admins/AdminLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LogId,Status,SessionId,AppCode,ThreadId,StartTime,EndTime,AdminUserId,UserLogin,UserName,IpAddress,ActionCode,ActionName,MenuCode,MenuName,WebpagesActionId,ActionType,ObjectId,Content,Description,LogLevel,ErrorCode")] AdminLog adminLog)
        {
            if (id != adminLog.LogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminLogExists(adminLog.LogId))
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
            return View(adminLog);
        }

        // GET: Admins/AdminLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdminLogs == null)
            {
                return NotFound();
            }

            var adminLog = await _context.AdminLogs
                .FirstOrDefaultAsync(m => m.LogId == id);
            if (adminLog == null)
            {
                return NotFound();
            }

            return View(adminLog);
        }

        // POST: Admins/AdminLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdminLogs == null)
            {
                return Problem("Entity set 'DevXuongMocSqlContext.AdminLogs'  is null.");
            }
            var adminLog = await _context.AdminLogs.FindAsync(id);
            if (adminLog != null)
            {
                _context.AdminLogs.Remove(adminLog);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminLogExists(int id)
        {
          return (_context.AdminLogs?.Any(e => e.LogId == id)).GetValueOrDefault();
        }
    }
}
