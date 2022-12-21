using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics;
using WebApplication8.Models;

namespace WebApplication8.Controllers 
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger; 


       // static user currentUser = new user();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUser(user userDetails)
        {
            
            userData.userList.Add(userDetails);

            return RedirectToAction("ShowUsers", "Admin");
        }

        public IActionResult Login()
        {
            return View("loginPage");
        }

        public IActionResult CheckCredentials(login inputDetails)
        {
            
            foreach (var eachUser in userData.userList)
            {
                if (eachUser.email == inputDetails.loginId && eachUser.password == inputDetails.password )
                {
                    currentUser.email = eachUser.email;
                    currentUser.name = eachUser.name;
                    currentUser.role = eachUser.role;
                    if (eachUser.role == "admin")
                    {
                        return RedirectToAction("adminIndex", "Admin", new { name = eachUser.name });
                    }
                    else
                    {
                        return RedirectToAction("customerIndex", "Customer", new { name = eachUser.name });
                    }
                }
            }
            ViewBag.errorMessage = "Invalid LoginId or password. Try again...";
            return View("loginPage");
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Logout()
        {
            currentUser.name = "";
            currentUser.email = "";
            currentUser.role = "";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}