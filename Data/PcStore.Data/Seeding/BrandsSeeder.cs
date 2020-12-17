namespace PcStore.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using PcStore.Data.Models;

    public class BrandsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Brands.Any())
            {
                return;
            }

            await dbContext.Brands.AddAsync(new Brand { Name = "Amd" });
            await dbContext.Brands.AddAsync(new Brand { Name = "Intel" });
            await dbContext.Brands.AddAsync(new Brand { Name = "nVidia" });
        }
    }
}