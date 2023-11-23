using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace BenjiApi.Models
{
    public class BenjiApiContext: DbContext
    {
        public Dbset<Animal> Animals {get; set; }
        public Dbset<AdoptionApplication> AdoptionApplications {get; set; }
        public Dbset<User> Users {get; set; }
        public BenjiApiContext(DbContextOptions<BenjiApi> options) : base(options)
    }
}

        