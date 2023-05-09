using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculationExercise
{
    public class NIC
    {
        public string Description { get; set; }
        public string MAC { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public string Rx { get; set; }
        public string Tx { get; set; }
    }
}


