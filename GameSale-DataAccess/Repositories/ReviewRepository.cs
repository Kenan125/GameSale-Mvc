using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.Interfaces;

namespace GameSale_DataAccess.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        private readonly GameSaleDb db;

        public ReviewRepository(GameSaleDb db) : base(db)
        {
            this.db = db;
        }
    }
}
