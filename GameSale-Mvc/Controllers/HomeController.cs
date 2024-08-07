using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            var result = unitOfWork.Game.GetAll();
            return View(result);
        }

    }
}
