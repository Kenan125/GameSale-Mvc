using Microsoft.AspNetCore.Mvc;

namespace GameSale_Mvc.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
