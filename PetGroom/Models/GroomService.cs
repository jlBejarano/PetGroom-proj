using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetGroom.Models
{
    public class GroomService
    {
        [Key]

        public int GrooomServiceId { get; set; }
        public string ServiceType { get; set; }
        public int Price { get; set; }
        public int NumberOfAnimals { get; set; }
    }
}
