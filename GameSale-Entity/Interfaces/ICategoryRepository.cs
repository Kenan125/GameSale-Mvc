using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;

namespace GameSale_Entity.Interfaces
{
    public interface ICategoryRepository 
    {
        Task<IEnumerable<CategoryViewModel>> GetAll();
        Task<CategoryViewModel> Get(int id);
        Task Add(CategoryViewModel model);
    }
}
