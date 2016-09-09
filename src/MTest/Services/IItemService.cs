using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListWithMigrations.Models;

namespace MTest.Services
{
    public interface IItemService
    {
        List<string> GetTest();
        List<Item> GetItems();
        List<Category> GetCategories();
    }
}
