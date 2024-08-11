using GameSale_Entity.Entities;
using GameSale_Entity.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameSale_Mvc.Controllers
{
    public class GameController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public GameController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public IActionResult Index()
        {
            var result = unitOfWork.Game.GetAllWithImages();
            return View(result);
        }
        

    }
}
