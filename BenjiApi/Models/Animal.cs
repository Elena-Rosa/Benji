using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace BenjiApi.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        
        [Required]
        public string Species { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [Range(0, 200, ErrorMessage = "Age must be between 0 and 200.")]
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string AdoptionStatus { get; set; }
    }
}