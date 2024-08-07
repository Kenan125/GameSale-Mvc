using GameSale_DataAccess.Contexts;
using GameSale_Entity.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        GameSaleDb _context;
        DbSet<T> _dbSet;

        public GenericRepository(GameSaleDb context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
            //return _context.Set<T>().ToList();
        }
        public T GetbyId(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }


        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
