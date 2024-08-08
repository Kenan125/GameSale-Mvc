namespace GameSale_Entity.Entities
{
    public class GameSaleDetail
    {
        public int Id { get; set; }
        public int GameSaleId { get; set; }
        public int GameId { get; set; }
        public int Number { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsRefundable { get; set; }

        public DateTime PurchaseDate { get; set; }

        public virtual GameSale GameSale { get; set; }

        public virtual Game Game { get; set; }

    }
}
