using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.ViewModels
{
	public class GameSaleViewModel
	{
		public int Id { get; set; }
		public int GameId { get; set; }
		public int CustomerId { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime SaleDate { get; set; }

		// You might include names instead of IDs if needed
		public string GameName { get; set; } // Mapped from Game
		public string CustomerName { get; set; } // Mapped from Customer
	}
}
