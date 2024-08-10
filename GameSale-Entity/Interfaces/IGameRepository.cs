using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;

namespace GameSale_Entity.Interfaces
{
    public interface IGameRepository
    {
        //IEnumerable<Game> GetAllWithImages();
		Task<IEnumerable<GameViewModel>> GetAll();
		Task<GameViewModel> Get(int id);
		Task Add(GameViewModel model);
	}
}
