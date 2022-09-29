using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Data;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStore.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _db;
        public UserController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(_db.Users.ToList());
        }

        //GET
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Users users )
        {
            if (users != null)
            {
                if (ModelState.IsValid)
                {
                    _db.Users.Add(users);
                    _db.SaveChanges();
                    return RedirectToAction("Index");

                }
            }
            return View(User);
        }
    }
}