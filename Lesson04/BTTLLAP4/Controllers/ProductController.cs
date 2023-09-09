using BTTLLAP4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BTTLLAP4.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            var products = Data.GetProducts();
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var products = Data.GetProductById(id);
            return View(products);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            Product model = new Product();
            return View(model);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Product model)
        {
            try
            {
                // upload file vào thư mục wwwroot/images/Image
                var files = HttpContext.Request.Form.Files;
                //using System.Linq;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    // nhớ tạo thư mục image trong wwwroot/image
                    //using System.IO;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Image", FileName);
                    using (var steam = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(steam);
                        model.Image = "Image" + FileName;// gán tên ảnh cho thuộc tính Avatar
                    }
                }
                // thêm peoples vào danh sách DataLocal
                Data.products.Add(model);
                return RedirectToAction(nameof(Index)); 
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View(model);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = Data.GetProductById(id);
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,  Product model)
        {
            try
            {
                // upload file vào thư mục wwwroot/images/Image
                var files = HttpContext.Request.Form.Files;
                //using System.Linq;
                if(files.Count()>0 && files[0].Length>0) {
                    var file = files[0];
                    var FileName = file.FileName;
                    // nhớ tạo thư mục image trong wwwroot/image
                    //using System.IO;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\Image",FileName);
                    using(var steam = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(steam);
                        model.Image = "Image" + FileName;// gán tên ảnh cho thuộc tính Avatar
                    }
                }
                for (int i = 0; i < Data.products.Count; i++)
                {
                    if (Data.products[i].Id==id)
                    {
                        Data.products[i] = model;
                        break;
                    }

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var products = Data.GetProductById(id);
            return View(products);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product model)
        {
            try
            {
                for (int i = 0; i < Data.products.Count; i++)
                {
                    if (Data.products[i].Id == id)
                    {
                        Data.products.RemoveAt(i);
                        break;
                    }
                }
                return  RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
