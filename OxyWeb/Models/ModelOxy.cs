using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OxyWeb.Models
{
    public partial class ModelOxy : DbContext
    {
        public ModelOxy(DbContextOptions<ModelOxy> options) : base(options)
        {
        }       

        public virtual DbSet<TCleaning> TCleanings { get; set; }
        public virtual DbSet<TEquipment> TEquipments { get; set; }
        public virtual DbSet<TEvent> TEvents { get; set; }
        public virtual DbSet<Tfield> Tfields { get; set; }
        public virtual DbSet<TLocation> TLocations { get; set; }
        public virtual DbSet<Tvendor> Tvendors { get; set; }
        public virtual DbSet<TWell> TWells { get; set; }
        public virtual DbSet<TUser> TUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("General");                  
        }

    }
}
