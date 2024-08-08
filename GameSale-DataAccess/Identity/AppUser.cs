using Microsoft.AspNetCore.Identity;

namespace GameSale_DataAccess.Identity
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
