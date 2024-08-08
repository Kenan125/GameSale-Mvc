using GameSale_DataAccess.Contexts;
using GameSale_DataAccess.Repositories;
using GameSale_Entity.Interfaces;
using GameSale_Entity.UnitOfWorks;

namespace GameSale_DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameSaleDb db;

        public UnitOfWork(GameSaleDb db)
        {
            this.db = db;
        }


        public IGameRepository Game => new GameRepository(db);
        public ICategoryRepository Category => new CategoryRepository(db);
        public ICustomerRepository Customer => new CustomerRepository(db);
        public IGameSaleDetailRepository GameSaleDetail => new GameSaleDetailRepository(db);
        public IGameSaleRepository GameSale => new GameSaleRepository(db);
        public IReviewRepository Review => new ReviewRepository(db);
        public ISystemRepository System => new SystemRepository(db);

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
