using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GameSale_DataAccess.Repositories
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        private readonly GameSaleDb db;

        public GameRepository(GameSaleDb db) : base(db)
        {
            this.db = db;
        }
        public IEnumerable<Game> GetAllWithImages()
        {
            return db.Games.Include(g => g.Images).ToList();
        }
    }
}
