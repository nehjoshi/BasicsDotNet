using Microsoft.AspNetCore.Mvc;

namespace BasicDotNetApp.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return Ok("Detail of ID: " + id);
        }
    }
}
