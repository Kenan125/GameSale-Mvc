using GameSale_Entity.Interfaces;

namespace GameSale_Entity.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        void Commit();
        void CommitAsync();
        /*IGameRepository Game { get; }
        ICustomerRepository Customer { get; }
        ICategoryRepository Category { get; }
        IGameSaleDetailRepository GameSaleDetail { get; }
        IGameSaleRepository GameSale { get; }
        IReviewRepository Review { get; }
        ISystemRepository System { get; }
        IPublisherRepository Publisher { get; }
        IImageRepository Image { get; }
        void Save();*/
    }
}
