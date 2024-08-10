using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.ViewModels
{
	public class GameWithImagesViewModel
	{
		// Game properties
		public int Id { get; set; }
		public string GameName { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Discount { get; set; }
		public string Developer { get; set; }
		public string Platform { get; set; }

		// Category and Publisher information
		public string CategoryName { get; set; }
		public string PublisherName { get; set; }

		// Images
		public List<ImageViewModel> Images { get; set; }
	}
}
