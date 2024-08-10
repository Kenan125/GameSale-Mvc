using GameSale_DataAccess.Contexts;
using GameSale_DataAccess.Repositories;
using GameSale_Entity.Interfaces;
using GameSale_Entity.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace GameSale_DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameSaleDb _context;
		private bool disposed = false;
        public UnitOfWork(GameSaleDb context)
        {
            _context = context;
        }
		
		public IRepository<T> GetRepository<T>() where T : class
		{
			return new GenericRepository<T>(_context);
		}
		public void Commit()
		{
			_context.SaveChanges();
		}

		public async void CommitAsync()
		{
			await _context.SaveChangesAsync();
		}

		public virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);  //GC - Garbage Collector
		}
		/*public IGameRepository Game => new GameRepository(db);
        public ICategoryRepository Category => new CategoryRepository(db);
        public ICustomerRepository Customer => new CustomerRepository(db);
        public IGameSaleDetailRepository GameSaleDetail => new GameSaleDetailRepository(db);
        public IGameSaleRepository GameSale => new GameSaleRepository(db);
        public IReviewRepository Review => new ReviewRepository(db);
        public ISystemRequirementRepository System => new SystemRepository(db);
        public IPublisherRepository Publisher => new PublisherRepository(db);
        public IImageRepository Image => new ImageRepository(db);

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }*/
	}
}
