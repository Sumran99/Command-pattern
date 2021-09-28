using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_a_
{
    class Hottub
    {
		public static int HIGH = 3;
		public static int MEDIUM = 2;
		public static int LOW = 1;
		public static int OFF = 0;
		int temperature;

		public Hottub()
		{

			temperature = OFF;
		}

		public void high()
		{
			temperature = HIGH;

		}
		public void medium()
		{
			temperature = MEDIUM;

		}

		public void low()
		{
			temperature = LOW;

		}

		public void off()
		{
			temperature = OFF;

		}
		public int getTemperature()
		{
			return temperature;
		}
	}
}
