using BasicDotNetApp.Data;
using BasicDotNetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicDotNetApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
