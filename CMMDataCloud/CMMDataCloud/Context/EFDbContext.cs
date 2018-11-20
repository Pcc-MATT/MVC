using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CMMDataCloud.Models.Context
{
    public class EFDbContext:DbContext
    {
        public DbSet<HeaderModels> Header { get; set; }
        public DbSet<CharacteristicModels> Characteristics { get; set; }
        public DbSet<FeaturesModels> Features { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}