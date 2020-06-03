using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetGroom.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Temper { get; set; }
        public string MedicalConditions { get; set; }
        public bool Allergies { get; set; }
    }
}
