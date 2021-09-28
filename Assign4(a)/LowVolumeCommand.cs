using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class LowVolumeCommand:Command
    {
        TV tv;
        public LowVolumeCommand(TV tv)
        {
            this.tv = tv;
        }
        public void execute()
        {
            tv.setVolume(-1);
        }
        public void undo()
        {
            tv.setVolume(1);
        }
    }
}
