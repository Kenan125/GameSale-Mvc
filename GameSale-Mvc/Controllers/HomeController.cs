using GameSale_Entity.Entities;
using GameSale_Entity.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;

namespace GameSale_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var games = unitOfWork.Game.GetAllWithImages().ToList();

            return View(games);
        }
        private List<Game> GetRandomGames(List<Game> games, int count)
        {
            var random = new Random();
            return games.OrderBy(x => random.Next()).Take(count).ToList();
        }
    }
}
