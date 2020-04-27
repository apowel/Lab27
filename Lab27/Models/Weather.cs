using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27.Models
{
    public class Weather
    {
        [Required]
        public Time Time { get; set; }
        [Required]
        public Data Data { get; set; }
        [Required]
        public Location Location { get; set; }
    }
}
