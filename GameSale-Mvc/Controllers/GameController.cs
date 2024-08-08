using GameSale_Entity.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;

namespace GameSale_Mvc.Controllers
{
    public class GameController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public GameController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        /*public IActionResult Details(int id) 
        {
            var game = unitOfWork.Game.GetbyId(id);
            if (game == null) 
            {
                return NotFound();
            
            }
            return View(game);

        
        }*/

        /*public IActionResult Search() 
        {
            //var result = unitOfWork.Game.Get(g => g.GameName.Contains(query));
            return View();
        }*/

        public IActionResult Index()
        {
            var result = unitOfWork.Game.GetAll();
            return View(result);
        }
    }
}
