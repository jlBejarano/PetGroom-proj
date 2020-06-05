using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetGroom.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public double CustomerPhoneNumber { get; set; }
        public int AnimalId { get; set; }
        public string PetName { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Temper { get; set; }
        public string MedicalConditions { get; set; }
        public bool Allergies { get; set; }
        public bool PickUpDropOff { get; set; }


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

       

       
    }
}
