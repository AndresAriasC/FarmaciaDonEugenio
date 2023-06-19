using Microsoft.EntityFrameworkCore;
using ProyectoProgramacionIIAPI.Models;
using System.Diagnostics;

namespace ProyectoProgramacionIIAPI.Data
{
    public class FarmaciaContext : DbContext
    {
        public FarmaciaContext(DbContextOptions<FarmaciaContext> options) : base(options)
        {
            //default empty
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                   new Product()
                   {
                       ProductId = 1,
                       ProductCode = "121",
                       ProductName = "Paracetamol",
                       ProductDescription = "No c",
                       CategoryId = 1
                   });

            modelBuilder.Entity<Category>().HasData(
                 new Category()
                 {
                     CategoryId = 1,
                     CategoryName = "Dolor"
                 });



        }

     }
}
