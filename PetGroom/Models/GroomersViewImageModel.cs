using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetGroom.Models
{
    public class GroomersViewImageModel
    {
        [Key]

        public string Title { get; set; }
    }
}
