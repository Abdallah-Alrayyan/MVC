using Day_8.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Day_8.Controllers
{
    public class UserController : Controller
    {
        private readonly MyDbContext DB;
        // GET: UserController
        public ActionResult Index()
        {
           
            return View();
        }

    

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        
        public ActionResult Create(User user)
        {
          
                DB.Users.Add(user);
                DB.SaveChanges();
                return RedirectToAction(nameof(Index));
            
        }







        // GET: UserController/Create
        public ActionResult Login()
        {

            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        public ActionResult Login(string Email, string password)
        {
            var user = DB.Users.FirstOrDefault(u => u.Email == Email && u.Password == password);
            if (user.Email == Email && user.Password == password)
            {
                return RedirectToAction(nameof(Index));
                TempData["name"] = user.Name;
            }
            return RedirectToAction(nameof(Index));

        }


       
    }
}
