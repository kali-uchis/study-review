using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using WebApplication8.Models;

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

        public  IActionResult ShowUsers()
        {
            //Database call to get the list of available users
            ViewBag.usersList = userData.userList;
            //Console.WriteLine(userData.userList);
            return View();
   
        }



    }
}
