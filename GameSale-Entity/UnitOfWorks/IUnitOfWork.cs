using GameSale_Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.UnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
        IGameRepository Game { get; }
        ICustomerRepository Customer { get; }
        ICategoryRepository Category { get; }
        IGameSaleDetailRepository GameSaleDetail { get; }
        IGameSaleRepository GameSale { get; }
        IReviewRepository Review { get; }
        ISystemRepository System { get; }
        void Save();
    }
}
