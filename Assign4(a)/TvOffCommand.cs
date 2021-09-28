using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class TvOffCommand:Command
    {
        TV tv;
        public TvOffCommand(TV tv)
        {
            this.tv = tv;
        }

        public void execute()
        {
           // tv.setInputChannel(0);
        }
        public void undo()
        {
           // tv.setInputChannel(0);
        }
    }
}
