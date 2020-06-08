using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetGroom.Models
{
    public class Groomer
    {
        [Key]
        public int GroomerId { get; set; }
        public string GroomerName { get; set; }

        


    }
}
