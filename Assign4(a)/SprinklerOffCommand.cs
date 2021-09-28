using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
    class SprinklerOffCommand: Command
    {
        Sprinkler sprinkler1;
        public SprinklerOffCommand(Sprinkler sprinkler)
        {
            this.sprinkler1 = sprinkler;
        }
        public void execute()
        {
            sprinkler1.waterOff();
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_sprinkler")
                {
                    lbl.Text = "Sprinkler Off :: Water off";
                }

            }
        }
        public void undo()
        {
            sprinkler1.waterOn();
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_sprinkler")
                {
                    lbl.Text = "Sprinkler On :: Water on";
                }

            }
        }
    }
}
