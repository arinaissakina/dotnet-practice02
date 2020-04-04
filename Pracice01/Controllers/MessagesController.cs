using Microsoft.AspNetCore.Mvc;

namespace Pracice01.Controllers
{
    public class MessagesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}