using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BenjiApi.Models
{
    public class BenjiApiContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AdoptionApplication> AdoptionApplications { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
        public BenjiApiContext(DbContextOptions<BenjiApiContext> options) : base(options)
        {
        }
    }
}


        