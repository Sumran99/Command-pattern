using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class OutdoorOnLight:Command
    {
        Outdoor_Light outdoor_Light;
        public OutdoorOnLight(Outdoor_Light outdoor_Light)
        {
            this.outdoor_Light = outdoor_Light;
        }
        public void execute()
        {
            outdoor_Light.on();
        }
        public void undo()
        {
            outdoor_Light.off();
        }

    }
}
