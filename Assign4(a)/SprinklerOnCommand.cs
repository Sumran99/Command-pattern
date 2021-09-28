using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
    class SprinklerOnCommand:Command
    {
        Sprinkler sprinkler;
        public SprinklerOnCommand(Sprinkler sprinkler)
        {
            this.sprinkler = sprinkler;
        }
        public void execute()
        {
            sprinkler.waterOn();

            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {
                
                if (lbl.Name == "lbl_sprinkler")
                {
                    lbl.Text = "Sprinkler On :: Water on";
                }
                
            }


           // Label lbl = Application.OpenForms["Form1"].Controls["lbl_sprinkler"] as Label;
            //lbl.Text = "Sprinkler On :: Water on";
        }
        public void undo()
        {
            sprinkler.waterOff();
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_sprinkler")
                {
                    lbl.Text = "Sprinkler Off :: Water off";
                }

            }

            //Label lbl = Application.OpenForms["Form1"].Controls["lbl_sprinkler"] as Label;
            //lbl.Text = "Sprinkler Off :: Water off";
        }
    }
}
