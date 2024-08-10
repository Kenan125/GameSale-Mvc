using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;

namespace GameSale_Entity.Interfaces
{
    public interface IReviewRepository 
    {
		Task<IEnumerable<ReviewViewModel>> GetAll();
		Task<ReviewViewModel> Get(int id);
		Task Add(ReviewViewModel model);
	}
}
