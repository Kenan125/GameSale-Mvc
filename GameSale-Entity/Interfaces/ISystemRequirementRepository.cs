using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;

namespace GameSale_Entity.Interfaces
{
    public interface ISystemRequirementRepository 
    {
		Task<IEnumerable<SystemRequirementViewModel>> GetAll();
		Task<SystemRequirementViewModel> Get(int id);
		Task Add(SystemRequirementViewModel model);
	}
}
