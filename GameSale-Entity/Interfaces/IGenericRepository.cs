using System.Linq.Expressions;

namespace GameSale_Entity.Interfaces
{
    public interface IGenericRepository<T> where T : class, new()
    {
        List<T> GetAll();
        T GetbyId(int id);

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
