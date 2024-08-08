using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.Interfaces;

namespace GameSale_DataAccess.Repositories
{
    public class SystemRepository : GenericRepository<SystemRequirement>, ISystemRepository
    {
        private readonly GameSaleDb db;

        public SystemRepository(GameSaleDb db) : base(db)
        {
            this.db = db;
        }
    }
}
