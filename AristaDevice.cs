using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculationExercise
{
    public class AristaDevice
    {
        public string Device { get; set; }
        public string Model { get; set; }
        public List<NIC> NIC { get; set; }
    }
}
