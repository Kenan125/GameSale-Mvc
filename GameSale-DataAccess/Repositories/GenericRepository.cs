using GameSale_DataAccess.Contexts;
using GameSale_Entity.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GameSale_DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly GameSaleDb _context;
        private DbSet<T> _dbSet;

		public GenericRepository(GameSaleDb context)  //UnitOfWork
		{
			_context = context;         //ara katman - veritabanı
			_dbSet = _context.Set<T>(); //tablo
		}
		public async Task Add(T entity)
		{
			await _dbSet.AddAsync(entity);
			//_context.SaveChanges();       //UnitofWork tarafından yapılacak.
			//_context.SaveChangesAsync();
		}
		public void Update(T entity)
		{
			_dbSet.Update(entity);
			//_context.SaveChanges();
		}
		public void Delete(int id)
		{
			var entity = _dbSet.Find(id);
			_dbSet.Remove(entity);
			//_context.SaveChanges();
		}
		public void Delete(T entity)
		{
			if (entity.GetType().GetProperty("IsDeleted") != null)
			{
				entity.GetType().GetProperty("IsDeleted").SetValue(entity, true);  //tabloda ISDeleted kullanıyorsak
				_dbSet.Update(entity);
			}
			else
			{
				_dbSet.Remove(entity);
			}
			//_context.SaveChanges();
		}
		public async Task<T> Get(Expression<Func<T, bool>> filter)
		{
			IQueryable<T> query = _dbSet;
			if (filter != null)
			{
				query = query.Where(filter);
			}
			return await query.FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, params Expression<Func<T, object>>[] includes)
		{
			IQueryable<T> query = _dbSet;
			if (filter != null)
			{
				query = query.Where(filter);
			}
			if (orderby != null)
			{
				query = orderby(query);
			}
			foreach (var tablo in includes)
			{
				query = query.Include(tablo);
			}
			return await query.ToListAsync();
		}
		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.AsNoTracking().ToListAsync();  //AsNoTracking() -> EF Core verileri takip etmiyor (modified, deleted gibi). 
		}
		public async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		/*public GenericRepository(GameSaleDb context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();

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
        }*/
	}
}
