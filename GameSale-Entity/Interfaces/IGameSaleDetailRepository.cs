using GameSale_Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.Interfaces
{
    public interface IGameSaleDetailRepository : IGenericRepository<GameSaleDetail>
    {
        void Add(global::GameSale_Mvc.Controllers.UserController user1);
        Task GetAllAsync();
    }
}
