using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetGroom.Models
{
    public class Schedule
    {
        
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
    }
}
