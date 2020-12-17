namespace PcStore.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using PcStore.Data.Common.Models;
    using PcStore.Data.Common.Repositories;

    public class ProductsService<TEntity> : IProductsService<TEntity>
        where TEntity : Product
    {
        private readonly IDeletableEntityRepository<TEntity> productsRepository;

        public ProductsService(IDeletableEntityRepository<TEntity> productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public TEntity GetById(int id)
        {
            var product = this.productsRepository.All().FirstOrDefault(p => p.Id == id);

            return product;
        }

        public IEnumerable<TEntity> GetAll()
        {
            var products = this.productsRepository.All();

            return products;
        }
    }
}