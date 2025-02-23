using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using New_Project;

namespace New_Project.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly OrangeContext _context;

        public DepartmentsController(OrangeContext context)
        {
            _context = context;
        }




        public IActionResult Index()
        {
            return View(_context.Departments.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Department department)
        {

            _context.Add(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}



























