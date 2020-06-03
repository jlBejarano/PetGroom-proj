using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetGroom.Models
{
    public class CustomerAnimalViewModel
    {
        [Key]
        public int CustomerId { get; set; }
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Temper { get; set; }
        public string MedicalConditions { get; set; }
        public string Allergies { get; set; }
        public int Price { get; set; }
        
    }
}
