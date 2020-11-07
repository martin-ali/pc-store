using App.Data;
using App.Models;

namespace App.Services
{
    public class ProcessorsService : IProcessorsService
    {
        private readonly PcStoreDbContext database;

        public ProcessorsService(PcStoreDbContext database)
        {
            this.database = database;
        }
        public void GenerateNew()
        {
            this.database.Processors.Add(new Processor());

            this.database.SaveChanges();
        }
    }
}