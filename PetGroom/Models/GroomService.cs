using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetGroom.Models
{
    public class GroomService
    {
        [Key]

        public int GrooomServiceId { get; set; }
        public string ServiceType { get; set; }
        public bool HairCut { get; set; }
        public bool PetBath { get; set; }
        public bool NailTrim { get; set; }
        public bool PetMassage { get; set; }
        public int NumberOfAnimals { get; set; }

        

    }
}
