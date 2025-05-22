using MenuApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApi.Infrastructure.Data
{
    public class MenuDbContext : DbContext
    {
        public MenuDbContext(DbContextOptions<MenuDbContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }





        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);


        //    modelBuilder.Entity<Menu>().HasData(
        //         new Menu { Id = 1, Name = "Spring Roll", Description = "Fusc tincidunt maximus leo", Category = "Forrett", SpecialTag = "", Price = 7.99, Image = "" },
        //         new Menu { Id = 2, Name = "Idli", Description = "Fusc tincidunt maximus leo...", Category = "Forrett", SpecialTag = "", Price = 8.99, Image = "" },
        //         new Menu { Id = 3, Name = "Panu Puri", Description = "Fusc tincidunt maximus leo...", Category = "Forrett", SpecialTag = "Bestselger", Price = 8.99, Image = "" },
        //         new Menu { Id = 4, Name = "Hakka Noodles", Description = "Fusc tincidunt maximus leo...", Category = "Hovedrett", SpecialTag = "", Price = 10.99, Image = "" }

        //        ); 
        //}
    }



}
