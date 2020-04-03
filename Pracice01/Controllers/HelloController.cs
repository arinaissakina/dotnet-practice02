using Microsoft.AspNetCore.Mvc;

namespace Pracice01.Controllers
{
    public class HelloController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}