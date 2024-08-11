using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.ViewModels
{
    public class GameDetailsViewModel
    {
        public int Id { get; set; }
        public string GameTitle { get; set; }
        
        public string PublisherName { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}
