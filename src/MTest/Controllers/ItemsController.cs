using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoListWithMigrations.Models;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {
        private ToDoDbContext db;// = new ToDoDbContext(  );
        public ItemsController (ToDoDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var list = db.Items.ToList();
            return View(list);
        }
    }
}