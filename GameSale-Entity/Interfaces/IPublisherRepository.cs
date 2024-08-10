using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.Interfaces
{
    public interface IPublisherRepository 
    {
		Task<IEnumerable<PublisherViewModel>> GetAll();
		Task<PublisherViewModel> Get(int id);
		Task Add(PublisherViewModel model);
	}
}
