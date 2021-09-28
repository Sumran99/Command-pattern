using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class PreviousChannelCommand:Command
    {
        TV tv;
        public PreviousChannelCommand(TV tv)
        {
            this.tv = tv;
        }
        public void execute()
        {
            tv.setInputChannel(-1);
        }
        public void undo()
        {
            tv.setInputChannel(1);
        }
    }
}
