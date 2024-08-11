using AutoMapper;
using GameSale_Entity.Entities;
using GameSale_Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Service.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile() 
		{ 
			CreateMap<Game, GameViewModel>().ReverseMap(); 
			CreateMap<Category, CategoryViewModel>().ReverseMap(); 
			CreateMap<Customer, CustomerViewModel>().ReverseMap(); 
			CreateMap<GameSale, GameSaleViewModel>().ReverseMap(); 
			CreateMap<GameSaleDetail, GameSaleDetailViewModel>().ReverseMap();
			CreateMap<Image, ImageViewModel>().ReverseMap();
			CreateMap<Publisher, PublisherViewModel>().ReverseMap();
            CreateMap<Review, ReviewViewModel>().ReverseMap();
            CreateMap<SystemRequirement, SystemRequirementViewModel>().ReverseMap();


        }
		
	}
}
