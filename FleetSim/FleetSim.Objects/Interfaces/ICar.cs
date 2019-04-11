using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Objects.Interfaces
{
    interface ICar
    {
        int year { get; set; }
        string make { get; set; }
        string model { get; set; }
    }
}
