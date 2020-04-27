using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27.Models
{
    public class Data
    {
        public string[] temperature { get; set; }
        public string[] pop { get; set; }
        public string[] weather { get; set; }
        public string[] iconLink { get; set; }
        public object[] hazard { get; set; }
        public object[] hazardUrl { get; set; }
        public string[] text { get; set; }
    }
}
