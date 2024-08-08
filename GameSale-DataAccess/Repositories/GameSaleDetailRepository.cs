using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.Interfaces;

namespace GameSale_DataAccess.Repositories
{
    public class GameSaleDetailRepository : GenericRepository<GameSaleDetail>, IGameSaleDetailRepository
    {
        private readonly GameSaleDb db;

        public GameSaleDetailRepository(GameSaleDb db) : base(db)
        {
            this.db = db;
        }
    }
}
