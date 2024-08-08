using GameSale_DataAccess.Contexts;
using GameSale_DataAccess.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace GameSale_Service.Extensions
{
    public static class DependencyExtensions
    {
        public static void AddExtensions(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(
                opt =>
                {
                    opt.Password.RequiredLength = 3;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireDigit = false;
                    opt.User.RequireUniqueEmail = true;
                    opt.Lockout.MaxFailedAccessAttempts = 3;
                    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                }
                ).AddEntityFrameworkStores<GameSaleDb>();
        }
    }
}
