using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace BenjiApi.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string AdoptionStatus { get; set; }
    }
}