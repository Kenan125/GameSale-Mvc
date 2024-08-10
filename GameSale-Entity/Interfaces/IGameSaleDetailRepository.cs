using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;

namespace GameSale_Entity.Interfaces
{
    public interface IGameSaleDetailRepository 
    {
		Task<IEnumerable<GameSaleDetailViewModel>> GetAll();
		Task<GameSaleDetailViewModel> Get(int id);
		Task Add(GameSaleDetailViewModel model);
	}
}
