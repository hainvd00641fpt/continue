using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductNetCore.Models;

namespace ProductNetCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        public ProductController(ProductContext context)
        {
            _context = context;
            _context = context;
            if (!_context.Products.Any())
            {
                _context.Products.Add(new Product()
                {
                    Name = "San pham 01",
                    Price = 100
                });
                _context.Products.Add(new Product()
                {
                    Name = "San pham 02",
                    Price = 300
                });
                _context.SaveChanges();
            }

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        public IActionResult GetList()
        {
            return View(_context.Products.ToList());
        }
        public IActionResult Save(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            TempData["message"] = "Create success";
            return new RedirectResult("GetList");
        }
        public IActionResult Update(int id)
        {
            var product = _context.Products.Find(id);
            if(!_context.Products.Any())
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult SaveUpdate( Product product)
        {
            var existProduct = _context.Products.Find(product.Id);
            if (!_context.Products.Any())
            {
                return NotFound();
            }
            existProduct.Name = product.Name;
            existProduct.Price = product.Price;
            _context.Products.Update(existProduct);
            _context.SaveChanges();
            TempData["message"] = "Update Success";
            return new RedirectResult("GetList");
        }
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Json(product);
        }
        
        [HttpDelete]
        public IActionResult DeleteMany(string ids)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Json(ids);
        }

    }
}