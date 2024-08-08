namespace GameSale_Entity.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Game> Games { get; set; }
    }
}
