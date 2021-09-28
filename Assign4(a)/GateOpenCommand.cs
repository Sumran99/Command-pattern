using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class GateOpenCommand:Command
    {
        GarageDoor garageDoor;
        public GateOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void execute()
        {
            garageDoor.up();
            garageDoor.LightOn();
        }
        public void undo()
        {
            garageDoor.down();
            garageDoor.LightOff();
        }
    }
}
