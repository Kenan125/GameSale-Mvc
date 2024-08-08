namespace GameSale_Entity.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual List<GameSale> GameSales { get; set; }
    }
}
