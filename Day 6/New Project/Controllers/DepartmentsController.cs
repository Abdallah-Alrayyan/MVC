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



















// GET: Departments
//public async Task<IActionResult> Index()
//{
//    return View(await _context.Departments.ToListAsync());
//}
// GET: Students


//// GET: Departments/Details/5
//public async Task<IActionResult> Details(int? id)
//{
//    if (id == null)
//    {
//        return NotFound();
//    }

//    var department = await _context.Departments
//        .FirstOrDefaultAsync(m => m.Id == id);
//    if (department == null)
//    {
//        return NotFound();
//    }

//    return View(department);
//}









//// GET: Departments/Create
//public IActionResult Create()
//{
//    return View();
//}

//// POST: Departments/Create
//// To protect from overposting attacks, enable the specific properties you want to bind to.
//// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Create([Bind("Id,DepartmentName,Location,ManagerId,CreatedAt")] Department department)
//{
//    if (ModelState.IsValid)
//    {
//        _context.Add(department);
//        await _context.SaveChangesAsync();
//        return RedirectToAction(nameof(Index));
//    }
//    return View(department);
//}

























//// GET: Departments/Edit/5
//public async Task<IActionResult> Edit(int? id)
//{
//    if (id == null)
//    {
//        return NotFound();
//    }

//    var department = await _context.Departments.FindAsync(id);
//    if (department == null)
//    {
//        return NotFound();
//    }
//    return View(department);
//}

//// POST: Departments/Edit/5
//// To protect from overposting attacks, enable the specific properties you want to bind to.
//// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> Edit(int id, [Bind("Id,DepartmentName,Location,ManagerId,CreatedAt")] Department department)
//{
//    if (id != department.Id)
//    {
//        return NotFound();
//    }

//    if (ModelState.IsValid)
//    {
//        try
//        {
//            _context.Update(department);
//            await _context.SaveChangesAsync();
//        }
//        catch (DbUpdateConcurrencyException)
//        {
//            if (!DepartmentExists(department.Id))
//            {
//                return NotFound();
//            }
//            else
//            {
//                throw;
//            }
//        }
//        return RedirectToAction(nameof(Index));
//    }
//    return View(department);
//}

//// GET: Departments/Delete/5
//public async Task<IActionResult> Delete(int? id)
//{
//    if (id == null)
//    {
//        return NotFound();
//    }

//    var department = await _context.Departments
//        .FirstOrDefaultAsync(m => m.Id == id);
//    if (department == null)
//    {
//        return NotFound();
//    }

//    return View(department);
//}

//// POST: Departments/Delete/5
//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public async Task<IActionResult> DeleteConfirmed(int id)
//{
//    var department = await _context.Departments.FindAsync(id);
//    if (department != null)
//    {
//        _context.Departments.Remove(department);
//    }

//    await _context.SaveChangesAsync();
//    return RedirectToAction(nameof(Index));
//}

//private bool DepartmentExists(int id)
//{
//    return _context.Departments.Any(e => e.Id == id);
//}

