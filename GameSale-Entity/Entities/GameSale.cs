using System.ComponentModel.DataAnnotations.Schema;

namespace GameSale_Entity.Entities
{
    public class GameSale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsDiscountApplied { get; set; }


        public virtual List<GameSaleDetail> GameSaleDetails { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
