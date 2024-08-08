using Microsoft.AspNetCore.Mvc;

namespace GameSale_Mvc.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
