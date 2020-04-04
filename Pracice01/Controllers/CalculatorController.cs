using Microsoft.AspNetCore.Mvc;

namespace Pracice01.Controllers
{
    public class CalculatorController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}