using Microsoft.AspNetCore.Mvc;

namespace SystemSell.AplicationWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
