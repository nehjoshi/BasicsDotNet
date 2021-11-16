using BasicDotNetApp.Data;
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
            return View();
        }
    }
}
