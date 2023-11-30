using Microsoft.AspNetCore.Mvc;

namespace SystemSell.AplicationWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
