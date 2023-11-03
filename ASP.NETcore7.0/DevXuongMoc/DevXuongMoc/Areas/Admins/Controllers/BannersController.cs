﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevXuongMoc.Models;
using X.PagedList;

namespace DevXuongMoc.Areas.Admins.Controllers
{
    //[Area("Admins")]
    public class BannersController : BaseController
    {
        private readonly DevXuongMocSqlContext _context;

        public BannersController(DevXuongMocSqlContext context)
        {
            _context = context;
        }

        // GET: Admins/Banners
        public async Task<IActionResult> Index(string name, int page = 1)
        {
            // Số bản ghi trên một trang
            int limit = 5;
            var banner = await _context.Banners.OrderBy(b => b.Id).DefaultIfEmpty().ToPagedListAsync(page, limit);
            // nếu có tham số name trên url
            if (!String.IsNullOrEmpty(name))
            {
                banner = await _context.Banners.Where(b => b.Title.Contains(name)).OrderBy(b => b.Id).DefaultIfEmpty().ToPagedListAsync(page, limit);
            }
            ViewBag.keyword = name;
            return View(banner);
        }

        // GET: Admins/Banners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Banners == null)
            {
                return NotFound();
            }

            var banner = await _context.Banners.DefaultIfEmpty()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banner == null)
            {
                return NotFound();
            }

            return View(banner);
        }

        // GET: Admins/Banners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Banners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,Title,SubTitle,Urls,Orders,Type,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Notes,Status,Isdelete")] Banner banner)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count()>0&& files[0].Length>0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    //upload ảnh vào thư mục wwwroot\\images\\Category
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\images\\banners", FileName);
                    using(var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        banner.Image = "/images/banners/" + FileName;
                        //gán tên ảnh cho thuộc tính Image
                    }
                }
                banner.CreatedDate = DateTime.Now;

                _context.Add(banner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banner);
        }

        // GET: Admins/Banners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Banners == null)
            {
                return NotFound();
            }

            var banner = await _context.Banners.DefaultIfEmpty().FirstOrDefaultAsync(bn => bn.Id == id);
            if (banner == null)
            {
                return NotFound();
            }
            return View(banner);
        }

        // POST: Admins/Banners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image,Title,SubTitle,Urls,Orders,Type,CreatedDate,UpdatedDate,AdminCreated,AdminUpdated,Notes,Status,Isdelete")] Banner banner)
        {
            if (id != banner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count() > 0 && files[0].Length > 0)
                    {
                        var file = files[0];
                        var FileName = file.FileName;
                        //upload ảnh vào thư mục wwwroot\\images\\Category
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\banners", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            banner.Image = "/images/banners/" + FileName;
                            //gán tên ảnh cho thuộc tính Image
                        }
                    }
                    banner.UpdatedDate = DateTime.Now;

                    _context.Update(banner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BannerExists(banner.Id))
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
            return View(banner);
        }

        // GET: Admins/Banners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Banners == null)
            {
                return NotFound();
            }

            var banner = await _context.Banners.DefaultIfEmpty()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banner == null)
            {
                return NotFound();
            }

            return View(banner);
        }

        // POST: Admins/Banners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Banners == null)
            {
                return Problem("Entity set 'DevXuongMocSqlContext.Banners'  is null.");
            }
            var banner = await _context.Banners.FindAsync(id);
            if (banner != null)
            {
                _context.Banners.Remove(banner);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BannerExists(int id)
        {
          return (_context.Banners?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
