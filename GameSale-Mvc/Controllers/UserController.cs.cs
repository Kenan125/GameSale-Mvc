using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameSale_Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserController userRepository;

        public UserController(IUnitOfWork unitOfWork, UserController userRepository)
        {
            this.unitOfWork = unitOfWork;
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var result = unitOfWork.Customer.GetAll();
            return View(result);
        }

        //private string? GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public IActionResult Details(int id)
        {
            var user = unitOfWork.Customer.GetbyId(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

       

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserController user)
        {
            if (ModelState.IsValid)
            {
                UserController.Add(user);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        private static void Add(UserController user)
        {
            throw new NotImplementedException();
        }

        public IActionResult Edit(int id)
        {
            var user = unitOfWork.Customer.GetbyId(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(UserController user)
        {
            if (ModelState.IsValid)
            {
                userRepository.Update(user);
                unitOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        private void Update(UserController user)
        {
            throw new NotImplementedException();
        }

        //public IActionResult Delete(Customer customer)
        //{
        //    var user = unitOfWork.Customer.Delete(customer);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    userRepository.Delete(id);
        //    unitOfWork.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        
    }
}