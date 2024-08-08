using Microsoft.AspNetCore.Identity;

namespace GameSale_DataAccess.Identity
{
    public class AppRole : IdentityRole<int>
    {
        public string Description { get; set; }
    }
}
