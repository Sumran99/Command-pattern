using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class CeilingFan
    {
		public static int HIGH = 3;
		public static int MEDIUM = 2;
		public static int LOW = 1;
		public static int OFF = 0;
		int speed;

		public CeilingFan()
		{
			
			speed = OFF;
		}

		public void high()
		{
			speed = HIGH;
			
		}
		public void medium()
		{
			speed = MEDIUM;
			
		}

		public void low()
		{
			speed = LOW;
			
		}

		public void off()
		{
			speed = OFF;
			
		}
		public int getSpeed()
		{
			return speed;
		}

	}
}
