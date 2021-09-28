using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
    class Thermostat
    {
        public int temperature;
        public void setTemperature(int temp)
        {
            if (temperature < 0 || temperature >= 10) 
            {
                temperature = 0;
            }
            else
            {
                temperature += temp;
            }
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_thermoTemp")
                {
                    lbl.Text = "Thermostat Temperature: "+temperature.ToString();
                }

            }

        }
        public void off()
        {
            temperature = 0;
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_thermoTemp")
                {
                    lbl.Text = "Thermostat Temperature: " + temperature.ToString();
                }

            }
            temperature = 0;
        }

    }
}
