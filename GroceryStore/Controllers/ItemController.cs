using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStore.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDbContext _db;
        public ItemController(AppDbContext db)
        {
            _db = db; 
        }
        public IActionResult Index()
        {
            return View(_db.Item.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }


    }
}