namespace PcStore.Services.Data
{
    using System.Collections.Generic;

    using PcStore.Data.Common.Models;

    public interface IProductsService<TEntity>
        where TEntity : Product
    {
        public TEntity GetById(int id);

        public IEnumerable<TEntity> GetAll();
    }
}