namespace PcStore.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using PcStore.Data.Models;

    public class ProcessorsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Processors.Any())
            {
                return;
            }

            var brands = new List<Brand>(dbContext.Brands);
            for (int i = 0; i < 100; i++)
            {
                var processor = new Processor
                {
                    Model = $"Processor-{i}",
                    Brand = brands[i % brands.Count],
                    Price = i,
                    CoresCount = i + 1,
                    ClockFrequency = (i / 100) + 0.5f,
                };

                await dbContext.Processors.AddAsync(processor);
            }
        }
    }
}