using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;

namespace GameSale_Entity.Interfaces
{
    public interface ICustomerRepository 
    {
		Task<IEnumerable<CustomerViewModel>> GetAll();
		Task<CustomerViewModel> Get(int id);
		Task Add(CustomerViewModel model);
	}
}
