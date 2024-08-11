namespace GameSale_Entity.Entities
{
    public class Publisher : BaseEntity
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
