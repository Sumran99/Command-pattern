using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class ThermoTemperature:Command
    {
        Thermostat thermostat;
        public ThermoTemperature(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }
        public void execute()
        {
            thermostat.setTemperature(1);
        }
        public void undo()
        {
            thermostat.setTemperature(-1);
        }
    }
}
