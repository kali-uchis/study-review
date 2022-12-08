using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View();
        }
        
        public IActionResult CreateUser()
        {
            return View();
        }
    }
}
