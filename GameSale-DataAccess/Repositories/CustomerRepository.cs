using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.Interfaces;

namespace GameSale_DataAccess.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly GameSaleDb db;

        public CustomerRepository(GameSaleDb db) : base(db)
        {
            this.db = db;
        }
    }
}
