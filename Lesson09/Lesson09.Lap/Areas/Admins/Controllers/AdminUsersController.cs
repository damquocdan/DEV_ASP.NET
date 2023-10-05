using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lesson09.Lap.Models;
using X.PagedList;

namespace Lesson09.Lap.Areas.Admins.Controllers
{
    public class AdminUsersController : BaseController
    {
        private readonly DevXuongMocContext _context;

        public AdminUsersController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: Admins/AdminUsers
        public async Task<IActionResult> Index(string name,int page=1)
        {
            int limit = 5;
            var adminuser = await _context.AdminUsers.OrderBy(au=>au.Id).ToPagedListAsync(page,limit);
            // nếu có tham số name trên url
            if (!String.IsNullOrEmpty(name))
            {
                adminuser=await _context.AdminUsers.Where(au=>au.Name.Contains(name)).OrderBy(au=>au.Id).ToPagedListAsync(page,limit);
            }
            ViewBag.keyword = name;
            return View(adminuser);
        }

        // GET: Admins/AdminUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdminUsers == null)
            {
                return NotFound();
            }

            var adminUser = await _context.AdminUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminUser == null)
            {
                return NotFound();
            }

            return View(adminUser);
        }

        // GET: Admins/AdminUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/AdminUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Account,Password,MaNhanSu,Name,Phone,Email,Avatar,IdPhongBan,NgayTao,NguoiTao,NgayCapNhat,NguoiCapNhat,SessionToken,Salt,IsAdmin,TrangThai,IsDelete")] AdminUser adminUser)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length >0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path =Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\images\\AdminUser", FileName);
                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        file.CopyTo(stream);
                        adminUser.Avatar = "/images/AdminUser/" + FileName;

                    }
                }
                _context.Add(adminUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminUser);
        }

        // GET: Admins/AdminUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdminUsers == null)
            {
                return NotFound();
            }

            var adminUser = await _context.AdminUsers.FindAsync(id);
            if (adminUser == null)
            {
                return NotFound();
            }
            return View(adminUser);
        }

        // POST: Admins/AdminUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Account,Password,MaNhanSu,Name,Phone,Email,Avatar,IdPhongBan,NgayTao,NguoiTao,NgayCapNhat,NguoiCapNhat,SessionToken,Salt,IsAdmin,TrangThai,IsDelete")] AdminUser adminUser)
        {
            if (id != adminUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count()>0 && files[0].Length >0) 
                    {
                        var file = files[0];
                        var FileName = file.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\AdminUser", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            adminUser.Avatar = "/images/AdminUser/" + FileName;

                        }
                    }
                    _context.Update(adminUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminUserExists(adminUser.Id))
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
            return View(adminUser);
        }

        // GET: Admins/AdminUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdminUsers == null)
            {
                return NotFound();
            }

            var adminUser = await _context.AdminUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminUser == null)
            {
                return NotFound();
            }

            return View(adminUser);
        }

        // POST: Admins/AdminUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdminUsers == null)
            {
                return Problem("Entity set 'DevXuongMocContext.AdminUsers'  is null.");
            }
            var adminUser = await _context.AdminUsers.FindAsync(id);
            if (adminUser != null)
            {
                _context.AdminUsers.Remove(adminUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminUserExists(int id)
        {
          return (_context.AdminUsers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
