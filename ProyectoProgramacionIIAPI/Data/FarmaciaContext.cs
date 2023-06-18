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
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                   new Product()
                   {
                       ProductId = 1,
                       ProductCode = "121",
                       ProductName = "Paracetamol",
                       ProductDescription = "No c",
                       CategoryId = 1,
                       DateOfCreation = DateTime.Now,
                       ProviderId = 1
                   });

            modelBuilder.Entity<Category>().HasData(
                 new Category()
                 {
                     CategoryId = 1,
                     CategoryName = "Dolor",
                     DateOfCreation = DateTime.Now,
                 });

            modelBuilder.Entity<Provider>().HasData(
                new Provider()
                {
                    ProviderId = 1,
                    RUTCode = "222",
                    ProviderName = "Laboratorios Ramos",
                    ProviderEmail = "labramos@gmail.com.ni",
                    ProviderPhone = 18002020,
                    ProviderDate = DateTime.Now,
                });

            modelBuilder.Entity<Client>().HasData(
                new Client()
                {
                    ClientId=1,
                    ClientName = "Agapito",
                    ClientLastName = "Díaz",
                    ClientEmail= "AgaDia@gmail.com",
                    ClientPhone = 77194813,
                    ClientAdress = "De donde venden chicha",
                    ClientDate = DateTime.Now
                });



        }

     }
}
