
using Microsoft.EntityFrameworkCore;
using RegisterVehicle.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterVehicle {
    class MyDBContext : DbContext {
        public DbSet <Vehicle> Vehicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=Vehicle");
        }


    }
}
