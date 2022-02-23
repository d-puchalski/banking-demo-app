//using BankingDemo.Core.Extensions.EF.Models;
//using Microsoft.EntityFrameworkCore;

//namespace BankingDemo.Core.Extensions.EF.Connections {
//    public class SqlDB : DbContext {

//        public DbSet<Calculation> Calculations { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//            => optionsBuilder.UseSqlServer("***");

//        protected override void OnModelCreating(ModelBuilder modelBuilder) {

//            //modelBuilder.Entity<Calculation>().ToContainer("Calculations");
//            base.OnModelCreating(modelBuilder);
//        }


//    }
//}