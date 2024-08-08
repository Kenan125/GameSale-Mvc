using Microsoft.AspNetCore.Mvc;

namespace GameSale_Mvc.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
