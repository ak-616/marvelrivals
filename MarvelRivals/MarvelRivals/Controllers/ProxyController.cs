using Microsoft.AspNetCore.Mvc;

namespace MarvelRivals.Controllers
{
    public class ProxyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
