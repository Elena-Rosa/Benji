using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace BenjiApi.Models
{
    public class Shelter
    {
        public int ShelterId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}