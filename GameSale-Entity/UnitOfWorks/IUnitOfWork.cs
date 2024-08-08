using GameSale_Entity.Interfaces;

namespace GameSale_Entity.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
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
