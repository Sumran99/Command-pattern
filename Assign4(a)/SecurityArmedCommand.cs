using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4_a_
{
    class SecurityArmedCommand: Command
    {
        Security_Control security_Control;
        public SecurityArmedCommand(Security_Control security_Control)
        {
            this.security_Control = security_Control;
        }
        public void execute()
        {
            security_Control.arm();
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_securityControl")
                {
                    lbl.Text = "Security Control: Armed";
                }

            }
        }
        public void undo()
        {
            security_Control.disarm();
            Panel myPanel = Application.OpenForms["Form1"].Controls["panel1"] as Panel;
            foreach (Label lbl in myPanel.Controls.OfType<Label>())
            {

                if (lbl.Name == "lbl_securityControl")
                {
                    lbl.Text = "Security Control: Dis_armed";
                }

            }
        }
    }
}
