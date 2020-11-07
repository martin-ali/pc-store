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

        public DbSet<Processor> Processors { get; set; }
    }
}
