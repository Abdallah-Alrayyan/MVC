using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Day_3.Models;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;


namespace Day_3.Controllers
{
    public class UserController : Controller
    {



        public IActionResult Login()
        {// Read
            var data = Request.Cookies["userInfo"];
            if (data != null)
                return RedirectToAction("Index", "Home");
            else
                return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult editProfile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(string name, string email, string password, string rpassword)
        {



            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetString("Email", email);
            HttpContext.Session.SetString("Password", password);
            HttpContext.Session.SetString("rpassword", rpassword);

            if (rpassword == password)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["SignupMsg"] = "Invalid Password! Try Again.";
            }



            return View();
        }


        public IActionResult HandleLogin(string email, string password, string rem)
        {
            var UEmail = HttpContext.Session.GetString("Email");
            var UPassword = HttpContext.Session.GetString("Password");
            HttpContext.Session.SetString("Admin", "admin@gmail.com");

            if (email == UEmail && password == UPassword)
            {
                if (rem != null)
                {
                    CookieOptions obj = new CookieOptions();
                    obj.Expires = DateTime.Now.AddDays(2);
                    //store
                    Response.Cookies.Append("userInfo", email, obj);
                }
                return RedirectToAction("Index", "Home");
            }
            else if (email == "admin@gmail.com" && password == "123")
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                TempData["LoginMsg"] = "Invalid Email or Password! Try Again.";
                return RedirectToAction("Login");
            }
        }
        public IActionResult Porfile()
        {


            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            ViewBag.Password = HttpContext.Session.GetString("Password");

            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");

        }

















































    }
}
