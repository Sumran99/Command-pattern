using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class TvOnCommand:Command
    {
        TV tv;
        public TvOnCommand(TV tv)
        {
            this.tv = tv;
        }
        public void execute()
        {
            
        }

        public void undo()
        {
            
        }
    }
}
