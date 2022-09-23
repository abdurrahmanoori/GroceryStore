using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Data;
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

        public IActionResult Create()
        {
            return View();
        }
    }
}