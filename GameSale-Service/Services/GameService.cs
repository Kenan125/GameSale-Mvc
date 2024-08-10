using AutoMapper;
using GameSale_Entity.Entities;
using GameSale_Entity.Interfaces;
using GameSale_Entity.UnitOfWorks;
using GameSale_Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Service.Services
{
	public class GameService : IGameRepository
	{
		private readonly IUnitOfWork _uow;
		private readonly IMapper _mapper;

		public GameService(IUnitOfWork uow, IMapper mapper)
		{
			_uow = uow;
			_mapper = mapper;
		}


		public Task Add(GameViewModel model)
		{
			throw new NotImplementedException();
		}

		public async Task<GameViewModel> Get(int id)
		{
			var game = await _uow.GetRepository<Game>().GetByIdAsync(id);
			return _mapper.Map<GameViewModel>(game);
		}

		public async Task<IEnumerable<GameViewModel>> GetAll()
		{
			var list = await _uow.GetRepository<Game>().GetAllAsync();
			return _mapper.Map<IEnumerable<GameViewModel>>(list);
		}
	}
}
