using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;

namespace GameSale_Entity.Interfaces
{
    public interface IGameSaleRepository 
    {
		Task<IEnumerable<GameSaleViewModel>> GetAll();
		Task<GameSaleViewModel> Get(int id);
		Task Add(GameSaleViewModel model);
	}
}
