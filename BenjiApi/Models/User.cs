using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace BenjiApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string PreferredAnimal { get; set; }
    }
}