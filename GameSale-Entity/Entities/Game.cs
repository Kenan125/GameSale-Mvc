using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Discount { get; set; }

        public string ImgUrl { get; set; }

        public string Developer { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Platform { get; set; }



        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
