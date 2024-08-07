using GameSale_DataAccess.Contexts;
using GameSale_Entity.Entities;
using GameSale_Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_DataAccess.Repositories
{
    public class CategoryRepository:GenericRepository<Category>,ICategoryRepository
    {
        private readonly GameSaleDb db;

        public CategoryRepository(GameSaleDb db):base(db)
        {
            this.db = db;
        }
    }
}
