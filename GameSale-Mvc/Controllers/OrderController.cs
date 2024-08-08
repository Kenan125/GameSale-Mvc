using Microsoft.AspNetCore.Mvc;

namespace GameSale_Mvc.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
