using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListWithMigrations.Models;

namespace MTest.Services
{
    public class ItemService : IItemService
    {
        private ToDoDbContext db;

        public ItemService(ToDoDbContext context)
        {
            db = context;
        }

        public List<Category> GetCategories()
        {
            var categories = db.Categories.ToList();
            //var categories = new List<Category>() {
            //    new Category { Name = "Bob", CategoryId = 1 },
            //    new Category { Name = "Tom", CategoryId = 2 },
            //    new Category { Name = "Pat", CategoryId = 3 }
            //};//db.Categories.ToList();
            return categories;
        }

        public List<Item> GetItems()
        {
            var items = db.Items.ToList();
            //var items = new List<Item>() { };
            return items;
        }
        public List<string> GetTest()
        {
            throw new NotImplementedException();
        }
    }
}
