using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.Interfaces;

namespace GameSale_DataAccess.Repositories
{
    public class GameSaleRepository : GenericRepository<GameSale>, IGameSaleRepository
    {
        private readonly GameSaleDb db;

        public GameSaleRepository(GameSaleDb db) : base(db)
        {
            this.db = db;
        }
    }
}
