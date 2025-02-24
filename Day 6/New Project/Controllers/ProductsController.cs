using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using New_Project;
using New_Project.Models;

namespace New_Project.Controllers
{
    public class ProductsController : Controller
    {
        private readonly OrangeContext _context;

        public ProductsController(OrangeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product Product)
        {

            _context.Add(Product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {

            var Product = _context.Product.Find(Id);

            return View(Product);

        }

        public IActionResult Edit(int Id)
        {

            var Product = _context.Product.Find(Id);

            return View(Product);

        }

        [HttpPost]
        public IActionResult Edit(Product S)
        {
            _context.Update(S);
            _context.SaveChanges();

            return RedirectToAction("Index");


        }

        public IActionResult Delete(int Id)
        {
            var Product = _context.Product.Find(Id);
            _context.Remove(Product);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
