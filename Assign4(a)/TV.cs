using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class TV
    {
        public int getChannel=0;
        public int getVolume=0;
        public void on()
        {

        }
        
        public void off()
        {
            getChannel = 0;
            getVolume = 0;
        }
        public void setInputChannel(int channelNumber)
        {
            this.getChannel += channelNumber;
            if(getChannel > 10)
            {
                getChannel = 0;
            }
            if(getChannel<0)
            {
                getChannel = 0;
            }
        }
        public void setVolume(int volumeNumber)
        {
            this.getVolume += volumeNumber;
            if (getVolume > 10)
            {
                getVolume = 0;
            }
            if (getVolume < 0)
            {
                getVolume = 0;
            }
        }
        
        
    }
}
