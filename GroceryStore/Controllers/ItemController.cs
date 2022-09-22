using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Data;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;
using GroceryStore.ViewModels;

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
            DAL d = new DAL();
            d.connect();
            d.cmd.CommandText = "SELECT dbo.itemStoreKeeper.Id, dbo.itemStoreKeeper.Name,dbo.Category.Name AS Category, dbo.Item.Price,dbo.item.Discount,dbo.itemStoreKeeper.Photo FROM((dbo.itemStoreKeeper INNER JOIN dbo.Category ON dbo.itemStoreKeeper.CategoryId = dbo.Category.Id) INNER JOIN dbo.Item ON dbo.Item.Id = dbo.itemStoreKeeper.Id)";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            List<ItemIndexViewModel> itemList = new List<ItemIndexViewModel>();
            while (d.dr.Read())
            {
                ItemIndexViewModel itemIndexViewModel = new ItemIndexViewModel();
                itemIndexViewModel.Id = Convert.ToInt32(d.dr["Id"]);
                itemIndexViewModel.Name = d.dr["Name"].ToString();
                itemIndexViewModel.Category = d.dr["Category"].ToString();
                itemIndexViewModel.Price = Convert.ToInt32(d.dr["Price"]);
                if (d.dr["Discount"] is int)
                    itemIndexViewModel.Discount = Convert.ToInt32(d.dr["Discount"]);
                itemList.Add(itemIndexViewModel);
            }
            d.disconnect();
            return View(itemList);
        }
        //GET Create
        public IActionResult Create()
        {
            ItemCreateViewModel item = new ItemCreateViewModel();
            item.itemStoreKeepersList =  _db.itemStoreKeeper.ToList();
            
            return View(item);
        }
        //POST Create
        [HttpPost]
        public IActionResult Create(ItemCreateViewModel itemCreateViewModel)
        {
            
            Item item = new Item
            {
                
                ItemStoreKepeerId=itemCreateViewModel.Id,
                Price = itemCreateViewModel.Price,
                Profit = itemCreateViewModel.Profit,
                Discount = itemCreateViewModel.Discount
            };

            _db.Item.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(_db.Item.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                _db.Item.Update(item);   
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View(_db.Item.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(Item item)
        {
            if(item != null)
            {
                _db.Item.Remove(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        //public IActionResult Delete(int id)
        //{
        //    if(_db.Item.Find(id) != null)
        //    {
        //        _db.Item.Remove(_db.Item.Find(id));
        //        _db.SaveChanges();
        //        Redirect
        //    }
        //}

    }
}