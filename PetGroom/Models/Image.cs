using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PetGroom.Models
{
    public class Image
    {
        [Key]

        public int ImageId { get; set; }
        public string Title { get; set; }
        [DisplayName("Upload File")]
        public string ImagePath { get; set; }
        
    }
}
