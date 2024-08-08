using Microsoft.AspNetCore.Mvc;

namespace GameSale_Mvc.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
