using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27.Models
{
    public class Time
    {
        public string layoutKey { get; set; }
        public string[] startPeriodName { get; set; }
        public DateTime[] startValidTime { get; set; }
        public string[] tempLabel { get; set; }
    }
}
