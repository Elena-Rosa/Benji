using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace BenjiApi.Models
{
    public class AdoptionApplication
    {
        public int AppId { get; set; }
        public string ApplicantName { get; set; }
        public string ContactInfo { get; set; }
        public string PreferredAnimal { get; set; }
        public string AppStatus { get; set; }
    }
}