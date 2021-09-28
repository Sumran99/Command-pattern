using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class NextChannelCommand:Command
    {
        TV tv;
        public NextChannelCommand(TV tv)
        {
            this.tv = tv;
        }
        public void execute()
        {
            tv.setInputChannel(1);
        }
        public void undo()
        {
            tv.setInputChannel(-1);
        }
    }
}
