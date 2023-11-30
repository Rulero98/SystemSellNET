using Microsoft.AspNetCore.Mvc;

namespace SystemSell.AplicationWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
