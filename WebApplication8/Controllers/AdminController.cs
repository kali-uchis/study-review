using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Runtime.InteropServices;
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

        public  IActionResult ShowUsers(string error = "")
        {
            //Database call to get the list of available users
            ViewBag.usersList = userData.userList;
            ViewBag.error = error; 

            //Console.WriteLine(userData.userList);
            return View();
   
        }

        public IActionResult DeleteUser()
        {

            ViewBag.usersList = userData.userList;
            return View();
        }



    }
}
