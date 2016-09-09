using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListWithMigrations.Models;
using MTest.Services;

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
            var cats = db.Categories.ToList();
            d.Add("items", list);
            d.Add("categories", cats);
            return View(d);
        }
        public IActionResult Inject()
        {
            return View();
        }
    }
}