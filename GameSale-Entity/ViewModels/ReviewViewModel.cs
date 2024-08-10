using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.ViewModels
{
	public class ReviewViewModel
	{
		public int Id { get; set; }
		public int GameId { get; set; }
		public int CustomerId { get; set; }
		public int Rating { get; set; }
		public string CustomerReview { get; set; }

		public string GameName { get; set; } // Mapped from Game
		public string CustomerName { get; set; } // Mapped from Customer
	}
}
