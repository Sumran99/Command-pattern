using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class ThermostatOffCommand:Command
    {
        Thermostat thermostat;
        int preTemperature;
        public ThermostatOffCommand(Thermostat thermostat)
        {
            this.thermostat = thermostat;
            preTemperature = thermostat.temperature;
        }
        public void execute()
        {
            thermostat.off();
        }
        public void undo()
        {
            thermostat.setTemperature(1);
        }

    }
}
