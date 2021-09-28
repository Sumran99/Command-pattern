using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
    class LightOffCommand:Command
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_light")
                {
                    lbl.Text = "Light Off";
                }

            }
            light.off();
        }
        public void undo()
        {
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_light")
                {
                    lbl.Text = "Light On";
                }

            }
            light.on();

        }
    }
}
