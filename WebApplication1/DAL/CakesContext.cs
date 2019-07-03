using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using WebApplication1.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication1.DAL
{
    public class CakesContext : DbContext
    {
        public CakesContext() : base("CakesContext")
        {

        }

        static CakesContext()
        {
            Database.SetInitializer<CakesContext>(new CakesInitiallizer());
        }

        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}