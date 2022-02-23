using BankingDemo.Core.Extensions.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingDemo.Core.Extensions.EF.Connections {
    public class CosmosDB : DbContext {

        public DbSet<Calculation> Calculations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseCosmos(
                "XXX",
                "XXX",
                databaseName: "BankingDemo");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Calculation>().ToContainer("Calculations");
            base.OnModelCreating(modelBuilder);
        }

        public static void CheckCosmosDBStructure() {
            using (CosmosDB db = new CosmosDB()) {
                //db.Database.EnsureDeleted();
                db.Database.EnsureCreatedAsync();
            }

        }


    }
}