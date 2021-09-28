using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class OutdoorOffLight:Command
    {
        Outdoor_Light outdoor_Light;
        public OutdoorOffLight(Outdoor_Light outdoor_Light)
        {
            this.outdoor_Light = outdoor_Light;
        }
        public void execute()
        {
            outdoor_Light.off();
        }
        public void undo()
        {
            outdoor_Light.on();
        }
    }
}
