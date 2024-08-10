namespace GameSale_Entity.Entities
{
    public class Category : BaseEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
