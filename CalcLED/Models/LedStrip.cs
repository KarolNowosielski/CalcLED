using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLED.Models
{
    public class LedStrip
    {
        public string Ref { get; set; }

        public string Name { get; set; }

        public StripType Type { get; set; }

        public VoltageType Voltage { get; set; }

        public decimal Power { get; set; }

        public decimal Current { get; set; }

        public decimal Lenght { get; set; }
        
    }
}
