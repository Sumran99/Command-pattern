using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class GateCloseCommand:Command
    {
        GarageDoor garageDoor;
        public GateCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void execute()
        {
            garageDoor.down();
            garageDoor.LightOff();
        }
        public void undo()
        {
            garageDoor.up();
            garageDoor.LightOn();
        }
    }
}
