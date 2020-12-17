namespace PcStore.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using PcStore.Data.Common.Models;
    using PcStore.Data.Models;

    public class ReviewsSeeder : ISeeder
    {
        private const int ItemsCount = 25;

        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Reviews.Any())
            {
                return;
            }

            var products = new List<Product>(dbContext.Products.Take(ItemsCount));
            var users = new List<ApplicationUser>(dbContext.Users.Take(ItemsCount));
            for (int i = 0; i < 100; i++)
            {
                var review = new Review
                {
                    Content = $"Review{i}",
                    Product = products[i % ItemsCount],
                    Author = users[i % ItemsCount],
                };

                await dbContext.Reviews.AddAsync(review);
            }
        }
    }
}