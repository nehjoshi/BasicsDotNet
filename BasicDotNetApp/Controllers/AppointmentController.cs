using Microsoft.AspNetCore.Mvc;

namespace BasicDotNetApp.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
