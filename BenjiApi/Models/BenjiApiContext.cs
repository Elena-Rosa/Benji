using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BenjiApi.Models
{
    public class BenjiApiContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public BenjiApiContext(DbContextOptions<BenjiApiContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Benji", Species = "Dog", Age = 7 },
          new Animal { AnimalId = 2, Name = "Pepper", Species = "Dog", Age = 10 },
          new Animal { AnimalId = 3, Name = "Billy", Species = "Bird", Age = 2 },
          new Animal { AnimalId = 4, Name = "Paco", Species = "Dog", Age = 4 },
          new Animal { AnimalId = 5, Name = "Mao", Species = "Cat", Age = 22 }
        );
    }
  }
}
    

        