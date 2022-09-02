using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Data;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStore.Controllers
{
    public class ItemStoreKeeperController : Controller
    {
        private readonly AppDbContext _db;
        public ItemStoreKeeperController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ItemStoreKeeperAndCategoryModel> itemStoreKeeperAndCategoryModels = new List<ItemStoreKeeperAndCategoryModel>();
            DAL d = new DAL();
            d.connect();
            //          d.cmd.CommandText = "SELECT dbo.itemStoreKeeper.Name,dbo.Category.Name AS Category,dbo.itemStoreKeeper.Description,dbo.itemStoreKeeper.Company,dbo.itemStoreKeeper.MadeIn,dbo.itemStoreKeeper.ExpireDate, dbo.itemStoreKeeper.Photo FROM dbo.Category INNER JOIN dbo.itemStoreKeeper ON dbo.Category.Id = dbo.itemStoreKeeper.CategoryId";
            d.cmd.CommandText = "SELECT dbo.itemStoreKeeper.Id, dbo.itemStoreKeeper.Name,dbo.itemStoreKeeper.RealPrice,dbo.Category.Name AS Category,dbo.itemStoreKeeper.Description,dbo.itemStoreKeeper.Company,dbo.itemStoreKeeper.MadeIn,dbo.itemStoreKeeper.ExpireDate,dbo.itemStoreKeeper.Photo FROM dbo.Category INNER JOIN dbo.itemStoreKeeper ON dbo.Category.Id = dbo.itemStoreKeeper.CategoryId";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                ItemStoreKeeperAndCategoryModel IC = new ItemStoreKeeperAndCategoryModel();
                if (d.dr["Id"] is int)
                    IC.Id = Convert.ToInt32(d.dr["Id"]);
                IC.Name = d.dr["Name"].ToString();
                IC.Category = d.dr["Category"].ToString();
                IC.Description = d.dr["Description"].ToString();
                IC.Company = d.dr["Company"].ToString();
                IC.MadeIn = d.dr["MadeIn"].ToString();
                if (d.dr["RealPrice"] is int)
                    IC.RealPrice = Convert.ToInt32(d.dr["RealPrice"]);
                if (d.dr["ExpireDate"] is DateTime)
                    IC.ExpireDate = Convert.ToDateTime(d.dr["ExpireDate"]);
                IC.Photo = d.dr["Photo"].ToString();
                itemStoreKeeperAndCategoryModels.Add(IC);

            }
            d.disconnect();
            return View(itemStoreKeeperAndCategoryModels);
            //var ItemAndCategory = (
            //from i in _db.itemStoreKeeper
            //join c in _db.Category on i.Id equals c.Id
            //select new ItemStoreKeeperAndCategoryModel
            //{
            //    Id = i.Id,
            //    Name = i.Name,
            //    Category = c.Name,
            //    Description = i.Description,
            //    RealPrice = i.RealPrice,
            //    Company = i.Company,
            //    Quantity = i.Quantity,
            //    MadeIn = i.MadeIn,
            //    Profit = i.Profit,
            //    Type = i.Type,
            //    ExpireDate = i.ExpireDate,
            //    Photo = i.Photo
            //}).ToList();

        }
        //GET Create
        public IActionResult Create()
        {
            ViewBag.CategoryList = _db.Category.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(ItemStoreKeeper itemStoreKeeper)
        {
            //    if (ModelState.IsValid)
            //    {
            _db.itemStoreKeeper.Add(itemStoreKeeper);
            _db.SaveChanges();
            //ViewBag.CategoryList = _db.Category.ToList();
            return RedirectToAction("Index");
            //}
            //return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.CategoryList = _db.Category.ToList();
            return View(_db.itemStoreKeeper.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(ItemStoreKeeper itemStoreKeeper)
        {
            if (itemStoreKeeper != null)
            {
                _db.itemStoreKeeper.Update(itemStoreKeeper);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();

        }
        //GET Delete
        public IActionResult Delete(int id)
        {
            ViewBag.SingleCategory= _db.Category.Single(c => c.Id == _db.itemStoreKeeper.Find(id).CategoryId);
            return View(_db.itemStoreKeeper.Find(id));
        }

        //POST Delete
        [HttpPost]
        public IActionResult Delete(ItemStoreKeeper itemStoreKeeper)
        {
            _db.itemStoreKeeper.Remove(itemStoreKeeper);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}