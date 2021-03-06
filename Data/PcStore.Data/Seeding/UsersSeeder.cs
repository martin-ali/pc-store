namespace PcStore.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using PcStore.Data.Models;

    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Any())
            {
                return;
            }

            for (int i = 0; i < 100; i++)
            {
                var user = new ApplicationUser
                {
                    UserName = $"User-{i}",
                };

                await dbContext.Users.AddAsync(user);
            };
        }
    }
}