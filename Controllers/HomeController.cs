using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {

        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            List<User> users = dbContext.users.Include(c=>c.CreatedDishes).ToList();
            return View(users);
        }

        [HttpGet("new")]
        public IActionResult AddChef()
        {
            return View();
        }

        [HttpGet("dishes")]
        public IActionResult dish()
        {
            List<Dish> mydish = dbContext.dishes
                .Include(d =>d.Creator)
                .ToList();

            return View(mydish);
        }

        [HttpGet("dishes/new")]
        public IActionResult AddDish()
        {
            List<User> users = dbContext.users.ToList();
            ViewBag.user = users;
            return View();
        }

        [HttpPost("postTheChef")]
         public IActionResult postTheChef(User chef)
        {
            if(ModelState.IsValid){

                dbContext.Add(chef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");

            }

            return View("AddChef");
        }

        [HttpPost("postDish")]
        public IActionResult postDish(Dish dish){
             if(ModelState.IsValid){

                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("dish");
            }
            List<User> users = dbContext.users.ToList();
            ViewBag.user = users;
            return View("addDish");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
