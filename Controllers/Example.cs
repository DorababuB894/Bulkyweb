using Microsoft.AspNetCore.Mvc;

namespace Bulkyweb.Controllers
{
    public class Example : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
