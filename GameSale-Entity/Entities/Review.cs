using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_Entity.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int CustomerId { get; set; }


        [Required] // Rating zorunlu alan
        public int Rating { get; set; }
        public string CustomerReview { get; set; }
        public DateTime ReviewDate { get; set; }


        [ForeignKey("GameId")]
        public Game Game { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
