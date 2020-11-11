namespace App.Data
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    using App.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class PcStoreDbContext : IdentityDbContext
    {
        public PcStoreDbContext(DbContextOptions<PcStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cooler> Coolers { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }
        public DbSet<MemoryModule> MemoryModules { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<StorageDevice> StorageDevices { get; set; }

    }
}
