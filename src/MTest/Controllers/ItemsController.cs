using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListWithMigrations.Models;
using MTest.Services;
using MTest.ViewModels;
using AutoMapper;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {
        private ToDoDbContext db;// = new ToDoDbContext(  );
        private IItemService _itemsService;

        public ItemsController (ToDoDbContext context)//, IItemService itemService)
        {
            db = context;
       //     _itemsService = itemService;
        }
        public IActionResult Index()
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
             
            var list = db.Items.ToList();
            //var cats = db.Categories.ToList();
            //d.Add("items", list);
            //d.Add("categories", cats);
            return View(list);
        }
        public IActionResult Inject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Inject(ItemViewModel model)
        {
            var newItem = Mapper.Map<Item>(model);
            //From class
            //newItem.CategoryId = 1;
            db.Items.Add(newItem);

            db.SaveChanges();
            return RedirectToAction("Inject");
            //return View();
        }
    }
}